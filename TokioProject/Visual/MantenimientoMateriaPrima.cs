using Entidades;
using Individual.Visual;
using System.Data;
using System.Drawing;
using Datos;

namespace GUIs.Visual
{
    public partial class MantenimientoMateriaPrima : Form
    {
        DBMateriaPrima dataBase = new DBMateriaPrima();

        public MantenimientoMateriaPrima()
        {
            InitializeComponent();
            materiaPrimaDGV.RowHeadersVisible = false;
        }

        private void CargarTabla()
        {
            try
            {
                List<MateriaPrima> lista = dataBase.CargarDatosMateriaPrima();

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
                new Emergente("advertencia", "EXITO", "Registro guardado correctamente!").ShowDialog();
                CargarTabla();
            }
        }

        private void buscarMateriaPrima_TextChanged(object sender, EventArgs e)
        {

        }
        //------------------------------------------------------------------------------------------
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materiaPrimaDGV.SelectedRows.Count > 0)
            {
                int selected = materiaPrimaDGV.CurrentRow.Index;
                int id = (int)materiaPrimaDGV.Rows[selected].Cells[0].Value;

                NewMateriaPrima editar = new NewMateriaPrima(id);
                //TRABAJO EN PROGRESO - NO TERMINADO
                editar.txtNombre.Text = (string)materiaPrimaDGV.Rows[selected].Cells[1].Value;
                editar.cmbProveedor.SelectedValue = (int)materiaPrimaDGV.Rows[selected].Cells[2].Value;
                editar.txtStock.Texts = (string)materiaPrimaDGV.Rows[selected].Cells[3].Value;
                editar.txtPrecio.Texts = (string)materiaPrimaDGV.Rows[selected].Cells[4].Value;
                editar.fechaUltCompra.Value = (DateTime)materiaPrimaDGV.Rows[selected].Cells[5].Value;


                if (editar.ShowDialog() != DialogResult.Abort)
                {
                    new Emergente("advertencia", "EXITO", "Datos actualizados correctamente!").ShowDialog();
                    CargarTabla();
                }
            }
        }
    }
}
