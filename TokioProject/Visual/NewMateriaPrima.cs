using Entidades;
using Individual.Visual;
using Datos;
using LibreriaGrupal;
using System.Data;
using CustomControls.RJControls;
using System.Diagnostics;
using Microsoft.Win32;
using System.Runtime.Serialization.Formatters.Binary;

namespace GUIs.Visual
{
    public partial class NewMateriaPrima : Form
    {
        private DataBase dataBase;
        private DBProveedor dBProveedor;
        private DBMateriaPrima dBMateriaPrima;
        private DBRegistros dbRegistros;
        private Utilidades utilidades;
        private MateriaPrima registroActual;
        private int id;
        public bool Guardado = false;
        private int posY = 0, posX = 0;

        private Proveedor proveedorInicial;
        private Tuple<int, string> colorInicial;

        public NewMateriaPrima(int id = 0)
        {
            InitializeComponent();
            this.id = id;
            dataBase = new DataBase();
            dBProveedor = new DBProveedor();
            dBMateriaPrima = new DBMateriaPrima();
            dbRegistros = new DBRegistros();
            utilidades = new Utilidades();
            CargarDatos();
            if (this.id > 0)
            {
                this.ActiveControl = null;
                lblTitulo.Text = "Editar Materia Prima";
                cmbCategoria.Enabled = false;
            }
        }

        public Proveedor ProveedorSeleccionado => (Proveedor)cmbProveedor.SelectedItem;

        public Tuple<int, string> ColorSeleccionado => (Tuple<int, string>)cmbColor.SelectedItem;

        private void NewMateriaPrima_Load(object sender, EventArgs e)
        {
            proveedorInicial = ProveedorSeleccionado;
            colorInicial = ColorSeleccionado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.id > 0)
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
                if (fechaUltCompra.Value <= DateTime.Now)
                {
                    if (FueronModificados())
                    {
                        MateriaPrima registroNuevo = CargarDatosDeFormulario();

                        this.registroActual = dBMateriaPrima.ObtenerMateriaPrimaPorId(this.id);
                        string descripcion = "";
                        if (dBMateriaPrima.EditarMateriaPrima(registroNuevo))
                        {
                            // Obtener el proveedor anterior y nuevo
                            int proveedorAnterior = (int)this.registroActual.Proveedor.Id;
                            int proveedorNuevo = (int)registroNuevo.Proveedor.Id;

                            // Verificar si el proveedor ha cambiado
                            if (proveedorAnterior != proveedorNuevo)
                            {
                                string nombreProveedorAnterior = proveedorAnterior != 0 ? cmbProveedor.GetItemText(cmbProveedor.Items[proveedorAnterior]) : "";
                                string nombreProveedorNuevo = proveedorNuevo != 0 ? cmbProveedor.GetItemText(cmbProveedor.Items[proveedorNuevo]) : "";
                                descripcion += $"• Proveedor: {nombreProveedorAnterior} => {nombreProveedorNuevo}\n";
                            }

                            foreach (var propiedad in typeof(MateriaPrima).GetProperties())
                            {
                                object valorAnterior = propiedad.GetValue(this.registroActual)!;
                                object valorNuevo = propiedad.GetValue(registroNuevo)!;

                                if (!Equals(valorAnterior, valorNuevo))
                                {
                                    string descripcionPropiedad = "";

                                    if (propiedad.Name == "Proveedor")
                                    {
                                        // El proveedor ya fue procesado antes, omitirlo aquí
                                        continue;
                                    }
                                    else
                                    {
                                        descripcionPropiedad = $"{propiedad.Name}: {valorAnterior} => {valorNuevo}";
                                        descripcion += $"• {descripcionPropiedad}\n";
                                    }
                                }
                            }

                            CrearRegistro(registroNuevo, registroNuevo.Id, descripcion);
                            MostrarMensajeEmergente("EXITO", "Datos actualizados correctamente!");
                            this.Guardado = true;
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
                else
                {
                    MostrarMensajeEmergente("AVISO", "La fecha de la última compra no puede ser mayor a la fecha actual");
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeEmergente("ERROR DE EXCEPCIÓN", ex.Message);
            }
        }

        private void Crear()
        {
            try
            {
                if (fechaUltCompra.Value <= DateTime.Now)
                {
                    if (ValidarCamposCrear())
                    {
                        MateriaPrima materiaPrima = CargarDatosDeFormulario();
                        int id = dBMateriaPrima.InsertarMateriaPrima(materiaPrima);
                        if (id > 0)
                        {
                            CrearRegistro(materiaPrima, id, "•Se ha creado este commoditie");
                            MostrarMensajeEmergente("EXITO", "Registro guardado correctamente!");
                            this.Guardado = true;
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
                        MostrarMensajeEmergente("AVISO", "Debe ingresar todos los campos correctamente");
                    }
                }
                else
                {
                    MostrarMensajeEmergente("AVISO", "La fecha de la última compra no puede ser mayor a la fecha actual");
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeEmergente("ERROR DE EXCEPCIÓN", ex.Message);
            }
        }

        private bool FueronModificados()
        {
            RJTextBox[] textBoxs = { txtDescripcion, txtPrecio, txtStock };
            foreach (RJTextBox textbox in textBoxs)
            {
                if (textbox.Modified)
                {
                    return true;
                }
            }

            if (cmbProveedor.SelectedItem != null && cmbColor.SelectedItem != null)
            {
                // Obtener los valores seleccionados actualmente
                Proveedor proveedorSeleccionado = ProveedorSeleccionado;
                Tuple<int, string> colorSeleccionado = ColorSeleccionado;

                // Comparar con los valores iniciales (guardados al cargar el formulario)
                if (proveedorSeleccionado.Id != proveedorInicial.Id || colorSeleccionado.Item1 != colorInicial.Item1)
                {
                    return true;
                }
            }

            return false;
        }

        private bool ValidarCamposCrear()
        {
            if (utilidades.estaVacio(txtDescripcion.Texts, txtPrecio.Texts, txtStock.Texts))
            {
                return false;
            }
            if (cmbCategoria.SelectedIndex == 0)
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
            CargarCategoria();
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
        private void CargarCategoria()
        {
            var categorias = new List<Tuple<int, string>>();

            dataBase.consultar("SELECT id, nombreCategoria FROM CategoriaMateriaPrima;");
            DataTable table = dataBase.Ds.Tables[0];

            foreach (DataRow row in table.Rows)
            {
                int id = (int)row["id"];
                string nombreCategoria = (string)row["nombreCategoria"];

                categorias.Add(new Tuple<int, string>(id, nombreCategoria));
            }

            var categoriaElegir = new Tuple<int, string>(0, "Elija un categoria...");
            categorias.Insert(0, categoriaElegir);

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Item2";
            cmbCategoria.ValueMember = "Item1";

            cmbCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
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

            if (this.id == 0)
            {
                for (int i = proveedores.Count - 1; i >= 0; i--)
                {
                    Proveedor proveedor = proveedores[i];
                    if (!proveedor.Activo)
                    {
                        proveedores.RemoveAt(i);
                    }
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

        private void CrearRegistro(MateriaPrima materiaPrima, int id, string descripcion)
        {
            var owner = this.Owner as FrmPrincipal;

            var registro = new Registros();
            registro.Fecha = DateTime.Now;
            registro.Usuario = owner!.Sesion;
            registro.Descripcion = descripcion;
            registro.Cantidad = (this.id == 0) ? materiaPrima.Stock : materiaPrima.Stock - this.registroActual.Stock;
            dbRegistros.CrearRegistro(registro, "m" + id);
        }

        private MateriaPrima CargarDatosDeFormulario()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            try
            {
                materiaPrima.Id = this.id;
                materiaPrima.Categoria = ((Tuple<int, string>)cmbCategoria.SelectedItem).Item2;
                materiaPrima.Descripcion = txtDescripcion.Texts.Trim();
                materiaPrima.Proveedor.Id = (int)cmbProveedor.SelectedValue;
                materiaPrima.Stock = int.Parse(txtStock.Texts.Trim());
                materiaPrima.Precio = double.Parse(txtPrecio.Texts.Trim());
                materiaPrima.FechaCompra = fechaUltCompra.Value;
                materiaPrima.Color = ((Tuple<int, string>)cmbColor.SelectedItem).Item2;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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

        // Evento para cerrar ventana
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
