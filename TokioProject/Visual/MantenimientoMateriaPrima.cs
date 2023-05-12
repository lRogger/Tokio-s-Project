using Entidades;
using Datos;
using Individual.Visual;
using System.Data;
using System.Drawing;

namespace GUIs.Visual
{
    public partial class MantenimientoMateriaPrima : Form
    {
        private DataBase db = new DataBase();
        private List<Prenda> listaPrendas;

        public MantenimientoMateriaPrima()
        {
            InitializeComponent();
            cbProveedor.SelectedIndex = 0;
            CargarTabla();
            materiaPrimaDGV.RowHeadersVisible = false;
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
                tbBuscarProducto.Text = "";

                materiaPrimaDGV.Rows.Clear();

                for (int i = 0; i < listaPrendas.Count; i++)
                {
                    materiaPrimaDGV.Rows.Add(listaPrendas[i].Id, listaPrendas[i].Nombre, listaPrendas[i].Categoria,
                        listaPrendas[i].Talla, listaPrendas[i].Color, listaPrendas[i].Stock,
                        listaPrendas[i].Precio, listaPrendas[i].Activo);
                    if (!listaPrendas[i].Activo && !cbInactivo.Checked)
                    {

                        materiaPrimaDGV.Rows[i].Visible = false;

                    }
                    if (!listaPrendas[i].Activo)
                    {
                        //productoDGV.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(242,231,243);
                        materiaPrimaDGV.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
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
            string talla = cbProveedor.Text;
            if (cbProveedor.Text == "Todas")
            {
                talla = "";
            }

            foreach (DataGridViewRow row in materiaPrimaDGV.Rows)
            {
                bool prendaCoincide = false;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (i != 3 && i != 7 && ("" + row.Cells[i].Value.ToString()).ToLower()
                        .Contains(tbBuscarProducto.Text.ToLower()))
                    {

                        prendaCoincide = true;
                        break;
                    }

                }
                if (!prendaCoincide || (!("" + row.Cells[3].Value.ToString()).ToLower()
                    .Equals(talla.ToLower()) && talla != "") || (!(bool)row.Cells[7].Value && !cbInactivo.Checked))
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
                foreach (DataGridViewRow row in materiaPrimaDGV.Rows)
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
            DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️", "Seguro que desea inhabilitar la materia prima?").ShowDialog();
            if (result == DialogResult.OK)
            {
                int i = materiaPrimaDGV.CurrentRow.Index;

                new DBProducto().InhabilitarProducto((int)materiaPrimaDGV.Rows[i].Cells["ID"].Value);

                CargarTabla();
            }
        }

        private void cbTalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbBuscarProducto.Text == "")
            {
                foreach (DataGridViewRow row in materiaPrimaDGV.Rows)
                {

                    row.Visible = true;
                }
            }
            FiltrarDGVProducto();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            NewMateriaPrima np = new NewMateriaPrima();
            np.Owner = this.ParentForm;

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
            if (materiaPrimaDGV.SelectedRows.Count > 0)
            {
                int i = materiaPrimaDGV.CurrentRow.Index;

                var productos = await new DBProducto().LeerProducto((int)materiaPrimaDGV.Rows[i].Cells["ID"].Value);
                Prenda p = productos[0];

                NewMateriaPrima nmp = new NewMateriaPrima(p.Id);
                nmp.lblTitulo.Text = "Editar Materia Prima";
                nmp.tbNombreMat.Texts = p.Nombre;
                nmp.tbProveedor.Text = p.Categoria;
                //nmp.fechaUltCompra.Text = p.Talla;
                nmp.tbDescrip.Texts = p.Descripcion;
                nmp.tbStock.Texts = p.Stock.ToString();
                nmp.tbPrecioUnitario.Texts = p.Precio.ToString();
                nmp.Owner = this.ParentForm;

                if (nmp.ShowDialog() != DialogResult.Abort)
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
                new Emergente("advertencia", "ERROR", "Debes seleccionar una materia prima").ShowDialog();
            }
        }

        private async void btnSuma_Click(object sender, EventArgs e)
        {
            if (materiaPrimaDGV.CurrentRow != null)
            {
                int i = materiaPrimaDGV.CurrentRow.Index;
                if (cbCantidad.Value > 0)
                {
                    DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️", $"Desea agregar {cbCantidad.Value}" +
                    $" a {materiaPrimaDGV.Rows[i].Cells["Nombre"].Value}?").ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string inactivo = "";
                        int stock = ((int)materiaPrimaDGV.Rows[i].Cells["Stock"].Value + (int)cbCantidad.Value);
                        int IDproducto = (int)materiaPrimaDGV.Rows[i].Cells["ID"].Value;
                        new DBProducto().ActualizarStock(stock, IDproducto);
                        if (Convert.ToInt32(materiaPrimaDGV.Rows[i].Cells["Stock"].Value) == 0 && cbCantidad.Value > 0)
                        {
                            db.instruccionDB($"UPDATE Productos SET " +
                                $"Activo=1 WHERE IDproducto = {IDproducto}");
                            inactivo = "•Se ha activado la materia prima por ingreso de stock\n";
                        }

                        //SECCION DONDE SE CREA EL REGISTRO
                        var parent = this.ParentForm as FrmPrincipal;
                        Persona usuario = parent!.Sesion;

                        var productos = await new DBProducto().LeerProducto(IDproducto);

                        Registros registro = new Registros();
                        registro.Fecha = DateTime.Now;
                        registro.Usuario = parent.Sesion;
                        registro.Producto = productos[0];
                        registro.Descripcion = inactivo + "•Stock alterado";
                        registro.Cantidad = (int)cbCantidad.Value;
                        new DBRegistros().CrearRegistro(registro);

                        //-------------------------------------------------------------------
                        cbCantidad.Value = 0;
                        CargarTabla();
                    }
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

        private void materiaPrimaDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (materiaPrimaDGV.CurrentRow != null)
            {
                int i = materiaPrimaDGV.CurrentRow.Index;
                int id = (int)materiaPrimaDGV.Rows[i].Cells["ID"].Value;
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

        private async void btnMenos_Click(object sender, EventArgs e)
        {
            if (materiaPrimaDGV.CurrentRow != null)
            {
                int i = materiaPrimaDGV.CurrentRow.Index;

                if (cbCantidad.Value > 0)
                {
                    if ((Convert.ToInt32(materiaPrimaDGV.Rows[i].Cells["Stock"].Value) - cbCantidad.Value) > 0)
                    {
                        DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️", $"Desea restar {cbCantidad.Value}" +
                        $" a {materiaPrimaDGV.Rows[i].Cells["Nombre"].Value}?").ShowDialog();
                        if (result == DialogResult.OK)
                        {

                            int stock = ((int)materiaPrimaDGV.Rows[i].Cells["Stock"].Value - (int)cbCantidad.Value);
                            int IDproducto = (int)materiaPrimaDGV.Rows[i].Cells["ID"].Value;
                            new DBProducto().ActualizarStock(stock, IDproducto);


                            //SECCION DONDE SE CREA EL REGISTRO
                            var parent = this.ParentForm as FrmPrincipal;
                            Persona usuario = parent!.Sesion;

                            var productos = await new DBProducto().LeerProducto(IDproducto);

                            Registros registro = new Registros();
                            registro.Fecha = DateTime.Now;
                            registro.Usuario = parent.Sesion;
                            registro.Producto = productos[0];
                            registro.Descripcion = "•Stock alterado";
                            registro.Cantidad = (int)cbCantidad.Value * -1;
                            new DBRegistros().CrearRegistro(registro);

                            //-------------------------------------------------------------------
                            cbCantidad.Value = 0;
                            CargarTabla();
                        }
                    }
                    else if ((Convert.ToInt32(materiaPrimaDGV.Rows[i].Cells["Stock"].Value) - cbCantidad.Value) == 0)
                    {
                        DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️", $"Al restar {cbCantidad.Value}" +
                        $" inactivará {materiaPrimaDGV.Rows[i].Cells["Nombre"].Value}, desea continuar?").ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            int IDproducto = (int)materiaPrimaDGV.Rows[i].Cells["ID"].Value;
                            int stock = ((int)materiaPrimaDGV.Rows[i].Cells["Stock"].Value - (int)cbCantidad.Value);
                            new DBProducto().ActualizarStock(stock, IDproducto);
                            db.instruccionDB($"UPDATE Productos SET " +
                                $"Activo= 0 WHERE IDproducto = {IDproducto}");

                            //SECCION DONDE SE CREA EL REGISTRO
                            var parent = this.ParentForm as FrmPrincipal;
                            Persona usuario = parent!.Sesion;

                            var productos = await new DBProducto().LeerProducto(IDproducto);

                            Registros registro = new Registros();
                            registro.Fecha = DateTime.Now;
                            registro.Usuario = parent.Sesion;
                            registro.Producto = productos[0];
                            registro.Descripcion = "•Stock Alterado\n•Producto inactivado por falta de stock";
                            registro.Cantidad = (int)cbCantidad.Value * -1;
                            new DBRegistros().CrearRegistro(registro);

                            //-------------------------------------------------------------------
                            cbCantidad.Value = 0;
                            CargarTabla();
                        }
                    }
                    else if ((Convert.ToInt32(materiaPrimaDGV.Rows[i].Cells["Stock"].Value) - cbCantidad.Value) < 0)
                    {
                        new Emergente("advertencia", "ERROR", "No hay tanto stock!").ShowDialog();
                    }
                }

            }
            else
            {
                new Emergente("advertencia", "ERROR", "No hay una fila seleccionada").ShowDialog();
            }
        }

        private void cbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void materiaPrimaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
