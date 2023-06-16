using Datos;
using Entidades;
using Individual.Visual;

namespace GUIs.Visual
{
    public partial class MantenimientoProveedor : Form
    {
        private DBProveedor dataBase;

        public MantenimientoProveedor()
        {
            InitializeComponent();
            dataBase = new DBProveedor();
            CargarTabla();
        }

        //Eventos click de las opciones del módulo (crear, editar, eliminar y refrescar)
        private void btnCrear_Click(object sender, EventArgs e)
        {
            NewProveedor proveedor = new NewProveedor();

            proveedor.ShowDialog();
            if (proveedor.Guardado)
            {
                CargarTabla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (proveedoresDGV.SelectedCells.Count > 0)
            {
                int selected = proveedoresDGV.CurrentRow.Index;

                NewProveedor proveedor = new NewProveedor();
                proveedor.cedProveedor.Enabled = false;

                proveedor.nomProveedor.Text = (string)proveedoresDGV.Rows[selected].Cells[1].Value;
                proveedor.cedProveedor.Text = (string)proveedoresDGV.Rows[selected].Cells[2].Value;
                proveedor.correoProveedor.Text = (string)proveedoresDGV.Rows[selected].Cells[3].Value;
                proveedor.telefProveedor.Text = (string)proveedoresDGV.Rows[selected].Cells[4].Value;

                proveedor.ShowDialog();
                if (proveedor.Guardado)
                {
                    CargarTabla();
                }
            }
            else
            {
                MostrarMensajeEmergente("AVISO", "Debe seleccionar un proveedor");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (proveedoresDGV.SelectedCells.Count > 0)
            {
                int valor = (checkActivos.Checked) ? 1 : 0;
                string accion = (checkActivos.Checked) ? "habilitar" : "inhabilitar";

                int selected = proveedoresDGV.CurrentRow.Index;
                string identificacion = (string)proveedoresDGV.Rows[selected].Cells[2].Value;

                DialogResult confirmacion = new Emergente("si / no", "CONFIRMACIÓN",
                                                          $"Está seguro de {accion} el proveedor?"
                                                          ).ShowDialog();
                if (confirmacion == DialogResult.OK)
                {
                    dataBase.DesactivarActivarProveedor(identificacion, valor);
                    CargarTabla();
                    verificarDGV();
                }
            }
            else
            {
                MostrarMensajeEmergente("AVISO", "Debe seleccionar un proveedor");
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }
        //----------------------------------------------------------------------------------------------------------------------------

        //Evento textChanged para buscar en la tabla

        private void buscarProveedor_TextChanged(object sender, EventArgs e)
        {
            busquedaDGV(buscarProveedor.Text.ToLower());
        }
        //Evento para mostrar proveedores inactivos
        private void checkActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarTabla();
            buscarProveedor.Clear();
            btnEliminar.Text = (checkActivos.Checked) ? "Habilitar" : "Inhabilitar";
            btnEditar.Enabled = (checkActivos.Checked) ? false : true;
        }
        //----------------------------------------------------------------------------------------------------------------------------

        //Metodo de cargar datos en la tabla
        private void CargarTabla()
        {
            try
            {
                List<Proveedor> lista = dataBase.CargarDatosProveedores();

                proveedoresDGV.Rows.Clear();
                foreach (Proveedor proveedor in lista)
                {
                    if (checkActivos.Checked && !proveedor.Activo)
                    {
                        proveedoresDGV.Rows.Add(
                            proveedor.Id, proveedor.Nombre,
                            proveedor.Cedula_ruc, proveedor.Correo,
                            proveedor.Telefono);
                    }
                    else if (!checkActivos.Checked && proveedor.Activo)
                    {
                        proveedoresDGV.Rows.Add(
                            proveedor.Id, proveedor.Nombre,
                            proveedor.Cedula_ruc, proveedor.Correo,
                            proveedor.Telefono);
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeEmergente("ERROR DE EXCEPCIÓN", ex.Message);
            }
        }

        //Metodo con algoritmo de busqueda
        private void busquedaDGV(string entrada)
        {
            proveedoresDGV.ClearSelection();

            foreach (DataGridViewRow row in proveedoresDGV.Rows)
            {
                string nombre = ((string)row.Cells[1].Value).ToLower();
                string cedula_ruc = ((string)row.Cells[2].Value).ToLower();
                string correo = ((string)row.Cells[3].Value).ToLower();

                row.Visible = (nombre.Contains(entrada) || cedula_ruc.Contains(entrada) || correo.Contains(entrada)) ? true : false;
            }
        }
        private void verificarDGV()
        {
            if (checkActivos.Checked && proveedoresDGV.Rows.Count < 1)
            {
                checkActivos.Checked = false;
            }
        }
        private void MostrarMensajeEmergente(string titulo, string mensaje)
        {
            new Emergente("advertencia", titulo, mensaje).ShowDialog();
        }
    }
}