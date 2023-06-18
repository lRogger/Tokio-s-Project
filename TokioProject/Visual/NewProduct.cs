using Entidades;
using Individual.Visual;
using Datos;
using MySqlX.XDevAPI.Relational;
using System.Globalization;
using LibreriaGrupal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data;

namespace GUIs.Visual
{
    public partial class NewProduct : Form
    {
        private DataBase db;
        private int id;
        int posY = 0, posX = 0;

        public NewProduct()
        {
            InitializeComponent();
            Cargardatos();
            db = new DataBase();
            id = -1;
            cbCateg.SelectedIndex = 0;
            cbColor.SelectedIndex = 0;
            cbTalla.SelectedIndex = 0;
            
        }

        public NewProduct(int id)
        {
            InitializeComponent();
            Cargardatos();
            db = new DataBase();
            this.id = id;
            cbCateg.SelectedIndex = 0;
            cbColor.SelectedIndex = 0;
            cbTalla.SelectedIndex = 0;
            
        }

        private void Cargardatos()
        {
            cbColor.DataSource = CargarListaColores().Tables[0];
            cbColor.DisplayMember = "Color";
            cbColor.ValueMember = "IdColor";

            cbCateg.DataSource = CargarListaCategoria().Tables[0];
            cbCateg.DisplayMember = "Categoria";
            cbCateg.ValueMember = "IdCategoria";

            cbTalla.DataSource = CargarListaTalla().Tables[0];
            cbTalla.DisplayMember = "Talla";
            cbTalla.ValueMember = "IdTalla";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(id == -1)
            {
                Enviar();

            }else
            {
                Editar();
            }
            
        }

        private DataSet CargarListaColores()
        {

            DataBase dsc = new DataBase();
            dsc.consultar("SELECT idColor, CAST(idColor AS VARCHAR) + '-' + Color AS Color FROM Colores;");
            return dsc.Ds;
        }

        private DataSet CargarListaCategoria()
        {
            DataBase dsc = new DataBase();
            dsc.consultar("SELECT IdCategoria, CAST(IdCategoria AS VARCHAR) + '-' + Categoria AS Categoria FROM CategoriaProducto;");
            return dsc.Ds;
        }

        private DataSet CargarListaTalla()
        {
            DataBase dsc = new DataBase();
            dsc.consultar("SELECT IdTalla, CAST(IdTalla AS VARCHAR) + '-' + Talla AS Talla FROM Talla;");
            return dsc.Ds;
        }

        private void Editar()
        {
            if (tbNombreProd.Texts.Trim() != "" && tbPrecio.Texts.Trim() != "" && tbStock.Texts.Trim() != "")
            {

                Prenda productoNuevo = new Prenda();
                productoNuevo.Nombre = tbNombreProd.Texts;
                productoNuevo.Categoria = cbCateg.SelectedValue?.ToString()+"";
                productoNuevo.Talla = cbTalla.SelectedValue?.ToString()+"";
                productoNuevo.Descripcion = tbDescrip.Texts;
                productoNuevo.Color = cbColor.SelectedValue?.ToString()+"";
                productoNuevo.Stock = Int32.Parse(tbStock.Texts);
                productoNuevo.Precio = Double.Parse(tbPrecio.Texts);
                productoNuevo.Id = id;

                var productoRegistro = new Prenda();
                productoRegistro.Nombre = tbNombreProd.Texts;
                productoRegistro.Categoria = cbCateg.Text;
                productoRegistro.Talla = cbTalla.Text;
                productoRegistro.Color = cbColor.Text;
                productoRegistro.Descripcion = tbDescrip.Texts;
                productoRegistro.Stock = Int32.Parse(tbStock.Texts);
                productoRegistro.Precio = Double.Parse(tbPrecio.Texts);
                productoRegistro.Id = id;

                var productos = new DBProducto().LeerProducto(id);
                Prenda productoAnterior = productos[0];
                if (productoNuevo.Stock==0)
                {
                    productoNuevo.Activo = false;
                }
                else
                {
                    productoNuevo.Activo = true;
                }


                //UPDATE DEL PRODUCTO
                new DBProducto().EditarProducto(productoNuevo, id);

                //SECCION PARA CREAR EL REGISTRO
                var owner = this.Owner as FrmPrincipal;

                Registros registro = new Registros();
                registro.Fecha = DateTime.Now;
                registro.Usuario = owner!.Sesion;
                registro.Producto = productoNuevo;
                if (productoNuevo.Stock == 0)
                {
                    registro.Descripcion = "•Se ha inactivado el producto por falta de stock\n";
                }else if(productoAnterior.Stock == 0 && productoNuevo.Stock>0)  {
                    registro.Descripcion = "•Se ha activado el producto por ingreso de stock\n";
                }

                foreach (var propiedad in typeof(Prenda).GetProperties())
                {
                    object valorAnterior = propiedad.GetValue(productoAnterior)!;
                    object valorNuevo = propiedad.GetValue(productoRegistro)!;

                    if (!Equals(valorAnterior, valorNuevo))
                    {
                        registro.Descripcion += $"•{propiedad.Name}: {valorAnterior} => {valorNuevo}\n";
                    }
                }
                registro.Cantidad = productoNuevo.Stock - productoAnterior.Stock;
                new DBRegistros().CrearRegistro(registro, "p"+registro.Producto.Id.ToString());

                //-------------------------------------------------------------------

                this.Close();
            }
            else
            {
                new Emergente("advertencia", "ERROR", "Hay campos sin completar").ShowDialog();
            }
        }

        private void Enviar()
        {
            if(tbNombreProd.Texts.Trim() != "" && tbPrecio.Texts.Trim() != "" && tbStock.Texts.Trim() != "")
            {
                Prenda p = new Prenda();
                p.Nombre = tbNombreProd.Texts;
                p.Categoria = cbCateg.SelectedValue?.ToString()+"";
                p.Talla = cbTalla.SelectedValue?.ToString()+"";
                p.Descripcion = tbDescrip.Texts.ToString();
                p.Color = cbColor.SelectedValue?.ToString()+"";
                p.Stock = Int32.Parse(tbStock.Texts);
                p.Precio = Double.Parse(tbPrecio.Texts);

                this.Hide();

                //INSERCIÓN DE PRODUCTO
                p.Id = new DBProducto().CrearProducto(p);

                //SECCION DONDE SE CREA EL REGISTRO
                var owner = this.Owner as FrmPrincipal;

                Registros registro = new Registros();
                registro.Fecha = DateTime.Now;
                registro.Usuario = owner!.Sesion;
                registro.Producto = p;
                registro.Descripcion = "•Se ha creado este producto";
                registro.Cantidad = p.Stock;
                new DBRegistros().CrearRegistro(registro, "p"+registro.Producto.Id.ToString());
                //-------------------------------------------------------------------

                

                

                this.Close();
            }
            else
            {
                new Emergente("advertencia", "ERROR", "Hay campos sin completar").ShowDialog();
            }
        }

        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();
            e.Handled = u.validar((char)e.KeyChar, "numero");

            if (tbStock.Texts.Length > 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();
            e.Handled = u.validar((char)e.KeyChar, "decimal");

            if ((e.KeyChar == ',') && (tbPrecio.Texts.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            if (tbPrecio.Texts.Length > 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tbNombreProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();
            e.Handled = u.validar((char)e.KeyChar, "letras");
        }

        private void NewProduct_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
