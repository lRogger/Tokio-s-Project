using Entidades;
using Datos;
using Individual.Visual;
using System.Data;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using GUIs.Properties;

namespace GUIs.Visual
{
    public partial class MantenimientoProducto : Form
    {
        private DataBase db = new DataBase();
        private List<Prenda> listaPrendas;

        public MantenimientoProducto()
        {
            InitializeComponent();
            cbTalla.SelectedIndex = 0;
            CargarTabla();
            productoDGV.RowHeadersVisible = false;
            listaPrendas = new List<Prenda>();
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

            listaPrendas = new List<Prenda>();

            try
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Prenda p = new Prenda();
                    p.Id = (int)fila["IDproducto"];
                    p.Categoria = "" + fila["Categoria"].ToString();
                    p.Descripcion = "" + fila["Descripcion"].ToString();
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
                new Emergente("advertencia", "ERROR", "Ha ocurrido un error al conectar con la base de datos\n " +
                    "Intenta nuevamente! " + ex).ShowDialog();
            }
            
        }

        private void FiltrarDGVProducto()
        {
            string talla = cbTalla.Text;
            if(cbTalla.Text == "Todas")
            {
                talla = "";
            }

            foreach (DataGridViewRow row in productoDGV.Rows)
            {
                bool prendaCoincide = false;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (i != 3 && (""+row.Cells[i].Value.ToString()).ToLower()
                        .Contains(tbBuscarProducto.Text.ToLower()))
                    {
                        prendaCoincide = true;
                        break;
                    }
                    
                }
                if (!prendaCoincide || (!(""+row.Cells[3].Value.ToString()).ToLower()
                    .Equals(talla.ToLower()) && talla != ""))
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }
            }
        }

        private void buscarProducto_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscarProducto.Text == "")
            {
                foreach (DataGridViewRow row in productoDGV.Rows)
                {

                    row.Visible = true;
                }
            }
            FiltrarDGVProducto();
            
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️", "Seguro ? si elimina el registro no podrá recuperarlo").ShowDialog();
            if (result == DialogResult.OK)
            {
                int i = productoDGV.CurrentRow.Index;

                await Task.Run(() => db.instruccionDB("Delete from Productos WHERE IDproducto = '" +
                        productoDGV.Rows[i].Cells["ID"].Value.ToString() + "'"));

                CargarTabla();
            }
        }

        private void cbTalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbBuscarProducto.Text == "")
            {
                foreach (DataGridViewRow row in productoDGV.Rows)
                {

                    row.Visible = true;
                }
            }
            FiltrarDGVProducto();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct();

            
            if (np.ShowDialog() != DialogResult.Abort)
            {
                new Emergente("advertencia", "HECHO", "El proceso se ha completado exitosamente").ShowDialog();
                CargarTabla();

            }
            else
            {
                new Emergente("advertencia", "ERROR", "Operación no completada").ShowDialog();
            }
            
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (productoDGV.SelectedRows.Count > 0)
            {
                int i = productoDGV.CurrentRow.Index;

                await Task.Run(() => db.consultar($"SELECT IDproducto, Nombre, " +
                    $"Categoria, Talla, Descripcion, Color, Stock, Precio" +
                    $" FROM Productos WHERE IDproducto = {productoDGV.Rows[i].Cells["ID"].Value}"));
                
                DataSet dsa = db.Ds;

                
                NewProduct np = new NewProduct(Int32.Parse(""+dsa.Tables[0].Rows[0]["IDproducto"].ToString()));
                np.lblTitulo.Text = "Editar Producto";
                np.tbNombreProd.Texts = ""+dsa.Tables[0].Rows[0]["Nombre"].ToString();
                np.cbCateg.Text = dsa.Tables[0].Rows[0]["Categoria"].ToString();
                np.cbTalla.Text = dsa.Tables[0].Rows[0]["Talla"].ToString(); 
                np.tbDescrip.Texts = ""+dsa.Tables[0].Rows[0]["Descripcion"].ToString();
                np.cbColor.Text = dsa.Tables[0].Rows[0]["Color"].ToString();
                np.tbStock.Texts = ""+dsa.Tables[0].Rows[0]["Stock"].ToString();
                np.tbPrecio.Texts = ""+dsa.Tables[0].Rows[0]["Precio"].ToString();


                if (np.ShowDialog() != DialogResult.Abort)
                {
                    new Emergente("advertencia", "HECHO", "El proceso se ha completado exitosamente").ShowDialog();
                    CargarTabla();
                }
                else
                {
                    new Emergente("advertencia", "ERROR", "Operación no completada").ShowDialog();
                }
            }
            else
            {
                new Emergente("advertencia", "ERROR", "Debes seleccionar un producto").ShowDialog();
            }
        }

        private async void btnSuma_Click(object sender, EventArgs e)
        {
            int i = productoDGV.CurrentRow.Index;
            DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️", $"Desea agregar {cbCantidad.Value}" +
                $" a {productoDGV.Rows[i].Cells["Nombre"].Value}?").ShowDialog();

            if (result == DialogResult.OK)
            {
                await Task.Run(() => db.instruccionDB($"UPDATE Productos SET " +
                    $"Stock={Convert.ToInt32(productoDGV.Rows[i].Cells["Stock"].Value)+cbCantidad.Value} " +
                    $"WHERE IDproducto = {productoDGV.Rows[i].Cells["ID"].Value}"));

                cbCantidad.Value = 0;
                CargarTabla();
            }
        }

        private void MantenimientoProducto_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void productoDGV_SelectionChanged(object sender, EventArgs e)
        {
            int i = productoDGV.CurrentRow.Index;
            int id = (int)productoDGV.Rows[i].Cells["ID"].Value;
            if(lblDesc.Visible == false)
            {
                lblDesc.Visible = true;
            }

            foreach(Prenda p in listaPrendas)
            {
                if(p.Id == id)
                {
                    lblDescripcion.Text = p.Descripcion;
                    
                    break;
                }
            }

            
        }

        private async void btnMenos_Click(object sender, EventArgs e)
        {
            int i = productoDGV.CurrentRow.Index;

            if ((Convert.ToInt32(productoDGV.Rows[i].Cells["Stock"].Value) - cbCantidad.Value) > 0)
            {
                DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️", $"Desea restar {cbCantidad.Value}" +
                $" a {productoDGV.Rows[i].Cells["Nombre"].Value}?").ShowDialog();
                if (result == DialogResult.OK)
                {
                    await Task.Run(() => db.instruccionDB($"UPDATE Productos SET " +
                        $"Stock={Convert.ToInt32(productoDGV.Rows[i].Cells["Stock"].Value) - cbCantidad.Value} " +
                        $"WHERE IDproducto = {productoDGV.Rows[i].Cells["ID"].Value}"));

                    CargarTabla();
                }
            }else if((Convert.ToInt32(productoDGV.Rows[i].Cells["Stock"].Value) - cbCantidad.Value) == 0)
            {
                DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️", $"Al restar {cbCantidad.Value}" +
                $" eliminará {productoDGV.Rows[i].Cells["Nombre"].Value}, desea continuar?").ShowDialog();
                if (result == DialogResult.OK)
                {
                    await Task.Run(() => db.instruccionDB($"DELETE FROM Productos " +
                        $"WHERE IDproducto = {productoDGV.Rows[i].Cells["ID"].Value}"));

                    CargarTabla();
                }
            }else if ((Convert.ToInt32(productoDGV.Rows[i].Cells["Stock"].Value) - cbCantidad.Value ) < 0)
            {
                new Emergente("advertencia", "ERROR", "No hay tanto stock!").ShowDialog();
            }
            
            
        }
    }
}
