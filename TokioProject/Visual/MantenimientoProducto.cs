using Entidades;
using Datos;
using Individual.Visual;
using System.Data;


namespace GUIs.Visual
{
    public partial class MantenimientoProducto : Form
    {
        private DataBase db = new DataBase();

        public MantenimientoProducto()
        {
            InitializeComponent();
            cbTalla.SelectedIndex = 0;
            CargarTabla();
            productoDGV.RowHeadersVisible = false;
        }

        private void usersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void CargarTabla()
        {

            btnRefrescar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            await Task.Run(() => db.consultar("SELECT IDproducto, Categoria, Talla, Nombre, Descripcion, Color" +
                ", Stock, Precio from Productos"));
            btnRefrescar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            DataSet ds = db.Ds;
            List<Prenda> listaPrendas = new List<Prenda>();
            try
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Prenda p = new Prenda();
                    p.Id = (int)fila["IDproducto"];
                    p.Categoria = "" + fila["Categoria"].ToString();
                    p.Talla = "" + fila["Talla"].ToString();
                    p.Nombre = "" + fila["Nombre"].ToString();
                    p.Color = "" + fila["Color"].ToString();
                    p.Stock = (int)fila["Stock"];
                    p.Precio = (double)fila["Precio"];
                    listaPrendas.Add(p);
                }
                productoDGV.Rows.Clear();
                foreach (Prenda prenda in listaPrendas)
                {
                    productoDGV.Rows.Add(prenda.Id, prenda.Nombre, prenda.Categoria, prenda.Talla
                        , prenda.Color, prenda.Stock, prenda.Precio);
                }
            }

            catch (Exception ex)
            {
                new Emergente("advertencia", "ERROR", "Ha ocurrido un error al cargar la tabla, " +
                    "intenta nuevamente! " + ex).ShowDialog();
            }

        }

        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {

        }


        private void buscarProducto_TextChanged(object sender, EventArgs e)
        {
            string talla = cbTalla.Text;
            if(cbTalla.Text == "Todas") {
                talla = "";
            }

            if (buscarProducto.Text.Trim() != "")
            {
                productoDGV.CurrentCell = null;
                foreach (DataGridViewRow row in productoDGV.Rows)
                {
                    bool encontrado = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 1)
                        {
                            continue;
                        }

                        if (cell.Value != null &&
                            (cell.Value.ToString() + "").ToLower().Contains(productoDGV.Text.ToLower()))
                        {
                            encontrado = true;
                            break;
                        }
                    }

                    if (encontrado && (talla == row.Cells[3].Value.ToString() || talla == ""))
                    {
                        row.Visible = true;
                    }
                    else
                    {

                        row.Visible = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in productoDGV.Rows)
                {
                    if (!row.Visible)
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️⚠️", "Seguro ? si elimina el registro no podrá recuperarlo").ShowDialog();
            if (result == DialogResult.OK)
            {
                int i = productoDGV.CurrentRow.Index;

                await Task.Run(() => db.instruccionDB("Delete from Productos WHERE IDproducto = " +
                        productoDGV.Rows[i].Cells["ID"].Value.ToString()));

                CargarTabla();
            }
        }
    }
}
