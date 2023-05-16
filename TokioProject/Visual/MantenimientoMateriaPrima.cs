using Entidades;
using Controladores;
using Individual.Visual;
using System.Data;
using System.Drawing;

namespace GUIs.Visual
{
    public partial class MantenimientoMateriaPrima : Form
    {
        CtrlMateriaPrima control = new CtrlMateriaPrima();

        public MantenimientoMateriaPrima()
        {
            InitializeComponent();
            cbProveedor.SelectedIndex = 0;
            materiaPrimaDGV.RowHeadersVisible = false;
        }

        private void CargarTabla()
        {
            try
            {
                List<MateriaPrima> lista = control.ListarMateriaPrima();

                materiaPrimaDGV.Rows.Clear();
                foreach (MateriaPrima materiaPrima in lista)
                {
                    materiaPrimaDGV.Rows.Add(
                        materiaPrima.Id, materiaPrima.Nombre,
                        materiaPrima.Proveedor.Cedula_ruc, materiaPrima.Stock,
                        materiaPrima.Precio, materiaPrima.FechaCompra.ToShortDateString());
                }
            }
            catch (Exception ex)
            {
                new Emergente("advertencia", "ERROR DE EXCEPCIÓN", ex.Message).ShowDialog();
            }
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
                new Emergente("advertencia", "HECHO", "El proceso se ha completado exitosamente").ShowDialog();
                CargarTabla();

            }
            else
            {
                new Emergente("advertencia", "ERROR", "Operación no completada").ShowDialog();
            }
        }

        private void buscarMateriaPrima_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
