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
            comboBox1.SelectedIndex = 0;
            CargarTabla();
            usersDGV.RowHeadersVisible = false;
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
                    p.Descripcion = "" + fila["Descripcion"].ToString();
                    p.Color = "" + fila["Color"].ToString();
                    p.Stock = (int)fila["Stock"];
                    p.Precio = (double)fila["Precio"];
                    listaPrendas.Add(p);
                }
                usersDGV.Rows.Clear();
                foreach (Prenda prenda in listaPrendas)
                {
                    usersDGV.Rows.Add(prenda.Id, prenda.Categoria, prenda.Talla, prenda.Nombre
                        , prenda.Descripcion, prenda.Color, prenda.Stock, prenda.Precio);
                }
            }

            catch (Exception ex)
            {
                new Emergente("advertencia", "ERROR", "Ha ocurrido un error al cargar la tabla, " +
                    "intenta nuevamente! " + ex).ShowDialog();
            }

        }
    }
}
