using Entidades;
using Individual.Visual;
using Datos;
using MySqlX.XDevAPI.Relational;
using System.Globalization;
using LibreriaGrupal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUIs.Visual
{
    public partial class NewMateriaPrima : Form
    {
        private DataBase db;
        private int id;
        int posY = 0, posX = 0;

        public NewMateriaPrima()
        {
            InitializeComponent();
            db = new DataBase();
            id = -1;

        }

        public NewMateriaPrima(int id)
        {
            InitializeComponent();
            db = new DataBase();
            this.id = id;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                Enviar();

            }
            else
            {
                Editar();
            }

        }

        private void Editar()
        {
            if (txtNombre.Texts.Trim() != "" && txtPrecio.Texts.Trim() != "" && txtStock.Texts.Trim() != "")
            {

                Prenda productoNuevo = new Prenda();
                productoNuevo.Nombre = txtNombre.Texts;
                productoNuevo.Descripcion = tbDescrip.Texts;
                productoNuevo.Stock = Int32.Parse(txtStock.Texts);
                productoNuevo.Precio = Double.Parse(txtPrecio.Texts);
                productoNuevo.Id = id;

                var productos = new DBProducto().LeerProducto(id);
                Prenda productoAnterior = productos[0];
                if (productoNuevo.Stock == 0)
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
                }
                else if (productoAnterior.Stock == 0 && productoNuevo.Stock > 0)
                {
                    registro.Descripcion = "•Se ha activado el producto por ingreso de stock\n";
                }

                foreach (var propiedad in typeof(Prenda).GetProperties())
                {
                    object valorAnterior = propiedad.GetValue(productoAnterior)!;
                    object valorNuevo = propiedad.GetValue(productoNuevo)!;

                    if (!Equals(valorAnterior, valorNuevo))
                    {
                        registro.Descripcion += $"•{propiedad.Name}: {valorAnterior} => {valorNuevo}\n";
                    }
                }
                registro.Cantidad = productoNuevo.Stock - productoAnterior.Stock;
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
            if (txtNombre.Texts.Trim() != "" && txtPrecio.Texts.Trim() != "" && txtStock.Texts.Trim() != "")
            {
                Prenda p = new Prenda();
                p.Nombre = txtNombre.Texts;
                p.Descripcion = tbDescrip.Texts;
                p.Stock = Int32.Parse(txtStock.Texts);
                p.Precio = Double.Parse(txtPrecio.Texts);

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

            if (txtStock.Texts.Length > 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();
            e.Handled = u.validar((char)e.KeyChar, "decimal");

            if ((e.KeyChar == ',') && (txtPrecio.Texts.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            if (txtPrecio.Texts.Length > 10 && !char.IsControl(e.KeyChar))
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
