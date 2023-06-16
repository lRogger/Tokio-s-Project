using Datos;
using Entidades;
using Individual.Visual;

namespace GUIs.Visual
{
    public partial class MantenimientoMateriaPrima : Form
    {
        private readonly DBMateriaPrima dbMateriaPrima;
        private readonly DBProveedor dBProveedor;
        private Proveedor proveedorSeleccionado;

        public MantenimientoMateriaPrima()
        {
            InitializeComponent();
            dbMateriaPrima = new DBMateriaPrima();
            dBProveedor = new DBProveedor();
            CargarProveedores();
            CargarTabla();
        }

        private void CargarTabla()
        {
            try
            {
                List<MateriaPrima> lista = dbMateriaPrima.CargarDatosMateriaPrima();

                materiaPrimaDGV.Rows.Clear();
                foreach (MateriaPrima materiaPrima in lista)
                {
                    materiaPrimaDGV.Rows.Add(
                        materiaPrima.Id, materiaPrima.Nombre,
                        materiaPrima.Color, materiaPrima.Stock,
                        materiaPrima.Proveedor.Nombre, materiaPrima.Precio,
                        materiaPrima.FechaCompra.ToShortDateString());
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeEmergente("ERROR DE EXCEPCIÓN", ex.Message);
            }
        }

        private void CargarProveedores()
        {
            var proveedores = dBProveedor.CargarDatosProveedores();

            var proveedorElegir = new Proveedor
            {
                Id = 0,
                Nombre = "TODOS", //Valor por defecto, elija un proveedor...
                Cedula_ruc = string.Empty,
                Correo = string.Empty,
                Telefono = string.Empty
            };

            for (int i = proveedores.Count - 1; i >= 0; i--)
            {
                Proveedor proveedor = proveedores[i];
                if (!proveedor.Activo)
                {
                    proveedores.RemoveAt(i); //Remover proveedores que no están activos
                }
            }
            proveedores.Insert(0, proveedorElegir);

            cbProveedor.DataSource = proveedores;
            cbProveedor.DisplayMember = "Nombre";
            cbProveedor.ValueMember = "Id";

            //Activar campo de busqueda
            cbProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void MantenimientoMateriaPrima_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Form crear = new NewMateriaPrima();
            if (crear.ShowDialog() != DialogResult.Abort)
            {
                CargarTabla();
            }
        }

        private void buscarMateriaPrima_TextChanged(object sender, EventArgs e)
        {
            busquedaDGV(buscarMateriaPrima.Text.ToLower());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materiaPrimaDGV.SelectedRows.Count > 0)
            {
                int selected = materiaPrimaDGV.CurrentRow.Index;
                int id = (int)materiaPrimaDGV.Rows[selected].Cells[0].Value;

                NewMateriaPrima editar = new NewMateriaPrima(id);

                //Obtener los indices para seleccione el valor correcto del comboBox de proveedor y color
                string nombreProveedor = (string)materiaPrimaDGV.Rows[selected].Cells[4].Value;
                int indiceProveedor = editar.cmbProveedor.FindStringExact(nombreProveedor);
                string nombreColor = (string)materiaPrimaDGV.Rows[selected].Cells[2].Value;
                int indiceColor = editar.cmbColor.FindStringExact(nombreColor);

                //Asignar los valores a la ventana de editar
                editar.txtNombre.Texts = materiaPrimaDGV.Rows[selected].Cells[1].Value.ToString();
                editar.cmbColor.SelectedIndex = indiceColor;
                editar.txtStock.Texts = materiaPrimaDGV.Rows[selected].Cells[3].Value.ToString();
                editar.cmbProveedor.SelectedIndex = indiceProveedor;
                editar.txtPrecio.Texts = materiaPrimaDGV.Rows[selected].Cells[5].Value.ToString();
                editar.fechaUltCompra.Value = DateTime.Parse(materiaPrimaDGV.Rows[selected].Cells[6].Value.ToString());

                if (editar.ShowDialog() != DialogResult.Abort)
                {
                    MostrarMensajeEmergente("EXITO", "Datos actualizados correctamente!");
                    CargarTabla();
                }
            }
            else
            {
                MostrarMensajeEmergente("AVISO", "Debe seleccionar una comoditie");
            }
        }
        private void MostrarMensajeEmergente(string titulo, string mensaje)
        {
            new Emergente("advertencia", titulo, mensaje).ShowDialog();
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            proveedorSeleccionado = cbProveedor.SelectedItem as Proveedor;
            busquedaDGV(buscarMateriaPrima.Text.ToLower());
        }

        private void busquedaDGV(string entrada)
        {
            materiaPrimaDGV.ClearSelection();

            foreach (DataGridViewRow row in materiaPrimaDGV.Rows)
            {
                string nombre = ((string)row.Cells[1].Value).ToLower();
                string color = ((string)row.Cells[2].Value).ToLower();

                bool filtroProveedor = proveedorSeleccionado == null || proveedorSeleccionado.Nombre == row.Cells[4].Value.ToString() || proveedorSeleccionado.Nombre == "TODOS";

                row.Visible = (nombre.Contains(entrada) || color.Contains(entrada)) && filtroProveedor;
            }
        }
    }
}