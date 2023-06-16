using Entidades;
using Individual.Visual;
using Datos;
using LibreriaGrupal;
using System.Data;
using CustomControls.RJControls;

namespace GUIs.Visual
{
    public partial class NewMateriaPrima : Form
    {
        private DataBase dataBase;
        private DBProveedor dBProveedor;
        private DBMateriaPrima dBMateriaPrima;
        private Utilidades utilidades;
        private int id;
        public bool Guardado = false;
        private int posY = 0, posX = 0;

        public NewMateriaPrima(int id = 0)
        {
            InitializeComponent();
            dataBase = new DataBase();
            dBProveedor = new DBProveedor();
            dBMateriaPrima = new DBMateriaPrima();
            utilidades = new Utilidades();
            CargarDatos();
            this.id = id;
            if (id > 0)
            {
                this.ActiveControl = null;
                lblTitulo.Text = "Editar Materia Prima";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                Editar();
            }
            else
            {
                Crear();
            }
        }

        private void Editar()
        {
            try
            {
                if (FueronModificados())
                {
                    MateriaPrima materiaPrima = CargarDatosDeFormulario();

                    if (dBMateriaPrima.EditarMateriaPrima(materiaPrima))
                    {
                        MostrarMensajeEmergente("EXITO", "Datos actualizados correctamente!");
                        this.Close();
                    }
                    else
                    {
                        MostrarMensajeEmergente("ERROR", "No se pudo actualizar");
                        this.Close();
                    }
                }
                else
                {
                    MostrarMensajeEmergente("AVISO", "No hubieron cambios para guardar");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeEmergente("ERROR DE EXCEPCIÓN", ex.Message);
            }
        }

        private bool FueronModificados()
        {
            RJTextBox[] textBoxs = { txtNombre, txtPrecio, txtStock };
            foreach (RJTextBox textbox in textBoxs)
            {
                if (textbox.Modified)
                {
                    return true;
                }
            }

            return false;
        }

        private void Crear()
        {
            try
            {
                if (ValidarCamposCrear())
                {
                    MateriaPrima materiaPrima = CargarDatosDeFormulario();

                    if (dBMateriaPrima.InsertarMateriaPrima(materiaPrima))
                    {
                        MostrarMensajeEmergente("EXITO", "Registro guardado correctamente!");
                        this.Close();
                    }
                    else
                    {
                        MostrarMensajeEmergente("ERROR", "No se pudo guardar el registro!");
                        this.Close();
                    }
                }
                else
                {
                    MostrarMensajeEmergente("AVISO", "Debe ingresar todos los campos");
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeEmergente("ERROR DE EXCEPCIÓN", ex.Message);
            }
        }

        private bool ValidarCamposCrear()
        {
            if (utilidades.estaVacio(txtNombre.Texts, txtPrecio.Texts, txtStock.Texts))
            {
                return false;
            }

            if (cmbColor.SelectedIndex == 0)
            {
                return false;
            }
            if (cmbProveedor.SelectedIndex == 0)
            {
                return false;
            }

            return true;
        }

        private void CargarDatos()
        {
            CargarColores();
            CargarProveedores();
        }

        private void CargarColores()
        {
            var colores = new List<Tuple<int, string>>();

            dataBase.consultar("SELECT idColor, Color FROM Colores;");
            DataTable table = dataBase.Ds.Tables[0];

            foreach (DataRow row in table.Rows)
            {
                int idColor = (System.Int16)row["idColor"];
                string color = (string)row["Color"];

                colores.Add(new Tuple<int, string>(idColor, color));
            }

            var colorElegir = new Tuple<int, string>(0, "Elija un color...");
            colores.Insert(0, colorElegir);

            cmbColor.DataSource = colores;
            cmbColor.DisplayMember = "Item2";
            cmbColor.ValueMember = "Item1";

            cmbColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbColor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CargarProveedores()
        {
            var proveedores = dBProveedor.CargarDatosProveedores();

            var proveedorElegir = new Proveedor
            {
                Id = 0,
                Nombre = "Elija un proveedor...",
                Cedula_ruc = string.Empty,
                Correo = string.Empty,
                Telefono = string.Empty
            };

            for (int i = proveedores.Count - 1; i >= 0; i--)
            {
                Proveedor proveedor = proveedores[i];
                if (!proveedor.Activo)
                {
                    proveedores.RemoveAt(i);
                }
            }
            proveedores.Insert(0, proveedorElegir);

            cmbProveedor.DataSource = proveedores;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Id";

            cmbProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void MostrarMensajeEmergente(string titulo, string mensaje)
        {
            new Emergente("advertencia", titulo, mensaje).ShowDialog();
        }

        private MateriaPrima CargarDatosDeFormulario()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrima.Nombre = txtNombre.Texts.Trim();
            materiaPrima.Proveedor.Id = (int)cmbProveedor.SelectedValue;
            materiaPrima.Stock = Int32.Parse(txtStock.Texts.Trim());
            materiaPrima.Precio = Double.Parse(txtPrecio.Texts.Trim());
            materiaPrima.FechaCompra = fechaUltCompra.Value;
            materiaPrima.Color = ((Tuple<int, string>)cmbColor.SelectedItem).Item2;
            return materiaPrima;
        }

        // Eventos keypress para validar los campos
        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = utilidades.validar((char)e.KeyChar, "numero");

            if (txtStock.Texts.Length > 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = utilidades.validar((char)e.KeyChar, "decimal");

            if ((e.KeyChar == ',') && (txtPrecio.Texts.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            if (txtPrecio.Texts.Length > 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Evento para mover la ventana
        private void NewProduct_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
