using Entidades;
using Individual.Visual;
using Datos;
using MySqlX.XDevAPI.Relational;
using System.Globalization;
using LibreriaGrupal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            db = new DataBase();
            id = -1;
            cbCateg.SelectedIndex = 0;
            cbColor.SelectedIndex = 0;
            cbTalla.SelectedIndex = 0;
        }

        public NewProduct(int id)
        {
            InitializeComponent();
            db = new DataBase();
            this.id = id;
            cbCateg.SelectedIndex = 0;
            cbColor.SelectedIndex = 0;
            cbTalla.SelectedIndex = 0;
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

        private async void Editar()
        {
            if (tbNombreProd.Texts.Trim() != "" && tbPrecio.Texts.Trim() != "" && tbStock.Texts.Trim() != "")
            {

                Prenda productoNuevo = new Prenda();
                productoNuevo.Nombre = tbNombreProd.Texts;
                productoNuevo.Categoria = cbCateg.Text;
                productoNuevo.Talla = cbTalla.Text;
                productoNuevo.Descripcion = tbDescrip.Texts;
                productoNuevo.Color = cbColor.Text;
                productoNuevo.Stock = Int32.Parse(tbStock.Texts);
                productoNuevo.Precio = Double.Parse(tbPrecio.Texts);
                productoNuevo.Id = id;

                var productos = await new DBProducto().LeerProducto(id);
                Prenda productoAnterior = productos[0];


                this.Hide();

                //UPDATE DEL PRODUCTO
                new DBProducto().EditarProducto(productoNuevo, id);

                //SECCION PARA CREAR EL REGISTRO
                var owner = this.Owner as FrmPrincipal;

                Registros registro = new Registros();
                registro.Fecha = DateTime.Now;
                registro.Usuario = owner!.Sesion;
                registro.Producto = productoNuevo;
                registro.Descripcion = "Se ha modificado el producto:\n";

                foreach (var propiedad in typeof(Prenda).GetProperties())
                {
                    object valorAnterior = propiedad.GetValue(productoAnterior)!;
                    object valorNuevo = propiedad.GetValue(productoNuevo)!;

                    if (!Equals(valorAnterior, valorNuevo))
                    {
                        registro.Descripcion += $"{propiedad.Name}: {valorAnterior} => {valorNuevo}\n";
                    }
                }
                registro.Cantidad = 0;
                new DBRegistros().CrearRegistro(registro);

                //-------------------------------------------------------------------

                this.Close();
            }
            else
            {
                new Emergente("advertencia", "ERROR", "Hay campos sin completar").ShowDialog();
            }
        }

        private async void Enviar()
        {
            if(tbNombreProd.Texts.Trim() != "" && tbPrecio.Texts.Trim() != "" && tbStock.Texts.Trim() != "")
            {
                Prenda p = new Prenda();
                p.Nombre = tbNombreProd.Texts;
                p.Categoria = cbCateg.Text;
                p.Talla = cbTalla.Text;
                p.Descripcion = tbDescrip.Texts;
                p.Color = cbColor.Text;
                p.Stock = Int32.Parse(tbStock.Texts);
                p.Precio = Double.Parse(tbPrecio.Texts);

                this.Hide();

                //INSERCIÓN DE PRODUCTO
                p.Id = await new DBProducto().CrearProducto(p);

                //SECCION DONDE SE CREA EL REGISTRO
                var owner = this.Owner as FrmPrincipal;

                Registros registro = new Registros();
                registro.Fecha = DateTime.Now;
                registro.Usuario = owner!.Sesion;
                registro.Producto = p;
                registro.Descripcion = "\nSe ha creado un nuevo producto";
                registro.Cantidad = 0;
                new DBRegistros().CrearRegistro(registro);
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
