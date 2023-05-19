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
                        materiaPrima.Color, materiaPrima.Stock,
                        materiaPrima.Proveedor.Nombre, materiaPrima.Precio,
                        materiaPrima.FechaCompra.ToShortDateString());
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
                    new Emergente("advertencia", "EXITO", "Datos actualizados correctamente!").ShowDialog();
                    CargarTabla();
                }
            }
        }
    }
}
