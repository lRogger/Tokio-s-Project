using Entidades;
using Datos;
using Individual.Visual;
using System.Data;
using System.Drawing;

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
            try
            {
                btnRefrescar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;

                listaPrendas = await new DBProducto().LeerProducto();

                btnRefrescar.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;

            
                productoDGV.Rows.Clear();

                for(int i=0; i<listaPrendas.Count; i++)
                {
                    productoDGV.Rows.Add(listaPrendas[i].Id, listaPrendas[i].Nombre, listaPrendas[i].Categoria,
                        listaPrendas[i].Talla, listaPrendas[i].Color, listaPrendas[i].Stock,
                        listaPrendas[i].Precio);
                    if (!listaPrendas[i].Activo && !cbInactivo.Checked)
                    {
                        
                        productoDGV.Rows[i].Visible = false;
                        productoDGV.Rows[i].ReadOnly = true;

                    }

                }
            }

            catch (Exception ex)
            {
                new Emergente("advertencia", "ERROR", "Ha ocurrido un error al conectar con la base de datos\n " +
                     ex.Message).ShowDialog();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️", "Seguro que desea inhabilitar producto?").ShowDialog();
            if (result == DialogResult.OK)
            {
                int i = productoDGV.CurrentRow.Index;

                new DBProducto().InhabilitarProducto((int)productoDGV.Rows[i].Cells["ID"].Value);

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

                var productos = await new DBProducto().LeerProducto((int)productoDGV.Rows[i].Cells["ID"].Value);
                Prenda p = productos[0];
                
                NewProduct np = new NewProduct(p.Id);
                np.lblTitulo.Text = "Editar Producto";
                np.tbNombreProd.Texts = p.Nombre;
                np.cbCateg.Text = p.Categoria;
                np.cbTalla.Text = p.Talla; 
                np.tbDescrip.Texts = p.Descripcion;
                np.cbColor.Text = p.Color;
                np.tbStock.Texts = p.Stock.ToString();
                np.tbPrecio.Texts = p.Precio.ToString();


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

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if(productoDGV.CurrentRow != null)
            {
                int i = productoDGV.CurrentRow.Index;
                DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️", $"Desea agregar {cbCantidad.Value}" +
                    $" a {productoDGV.Rows[i].Cells["Nombre"].Value}?").ShowDialog();

                if (result == DialogResult.OK)
                {
                    db.instruccionDB($"UPDATE Productos SET " +
                        $"Stock={Convert.ToInt32(productoDGV.Rows[i].Cells["Stock"].Value) + cbCantidad.Value} " +
                        $"WHERE IDproducto = {productoDGV.Rows[i].Cells["ID"].Value}");

                    cbCantidad.Value = 0;
                    CargarTabla();
                }
            }
            else
            {
                new Emergente("advertencia", "ERROR", "No hay una fila seleccionada").ShowDialog();
            }
            
        }

        private void MantenimientoProducto_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void productoDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (productoDGV.CurrentRow != null)
            {
                int i = productoDGV.CurrentRow.Index;
                int id = (int)productoDGV.Rows[i].Cells["ID"].Value;
                if (lblDesc.Visible == false)
                {
                    lblDesc.Visible = true;
                }

                foreach (Prenda p in listaPrendas)
                {
                    if (p.Id == id)
                    {
                        lblDescripcion.Text = p.Descripcion;

                        break;
                    }
                }
            }    
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if(productoDGV.CurrentRow != null)
            {
                int i = productoDGV.CurrentRow.Index;

                if ((Convert.ToInt32(productoDGV.Rows[i].Cells["Stock"].Value) - cbCantidad.Value) > 0)
                {
                    DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️", $"Desea restar {cbCantidad.Value}" +
                    $" a {productoDGV.Rows[i].Cells["Nombre"].Value}?").ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        db.instruccionDB($"UPDATE Productos SET " +
                            $"Stock={Convert.ToInt32(productoDGV.Rows[i].Cells["Stock"].Value) - cbCantidad.Value} " +
                            $"WHERE IDproducto = {productoDGV.Rows[i].Cells["ID"].Value}");

                        CargarTabla();
                    }
                }
                else if ((Convert.ToInt32(productoDGV.Rows[i].Cells["Stock"].Value) - cbCantidad.Value) == 0)
                {
                    DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️", $"Al restar {cbCantidad.Value}" +
                    $" inactivará {productoDGV.Rows[i].Cells["Nombre"].Value}, desea continuar?").ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        db.instruccionDB($"UPDATE Productos SET " +
                            $"Activo= 0 WHERE IDproducto = {productoDGV.Rows[i].Cells["ID"].Value}");

                        CargarTabla();
                    }
                }
                else if ((Convert.ToInt32(productoDGV.Rows[i].Cells["Stock"].Value) - cbCantidad.Value) < 0)
                {
                    new Emergente("advertencia", "ERROR", "No hay tanto stock!").ShowDialog();
                }
            }
            else
            {
                new Emergente("advertencia", "ERROR", "No hay una fila seleccionada").ShowDialog();
            }
            
            
            
        }
    }
}
