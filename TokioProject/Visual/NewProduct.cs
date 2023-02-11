using Entidades;
using Individual.Visual;
using Datos;
using MySqlX.XDevAPI.Relational;
using System.Globalization;
using LibreriaGrupal;

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

                Prenda p = new Prenda();
                p.Nombre = tbNombreProd.Texts;
                p.Categoria = cbCateg.Text;
                p.Talla = cbTalla.Text;
                p.Descripcion = tbDescrip.Texts;
                p.Color = cbColor.Text;
                p.Stock = Int32.Parse(tbStock.Texts);
                p.Precio = Double.Parse(tbPrecio.Texts);

                //Esto se usa por problemas con double en mysql
                string doubleArreglado = p.Precio.ToString("0.00", CultureInfo.InvariantCulture);

                this.Hide();

                await Task.Run(() => db.instruccionDB($"UPDATE Productos SET " +
                    $"Nombre='{p.Nombre}',Categoria='{p.Categoria}',Talla='{p.Talla}'," +
                    $"Descripcion='{p.Descripcion}',Color='{p.Color}'," +
                    $"Stock={p.Stock},Precio='{doubleArreglado}' WHERE IDproducto = '{id}'"));

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
                p.Precio = double.Parse(tbPrecio.Texts);

                this.Hide();
                
                

                await Task.Run(() => db.instruccionDB($"INSERT INTO Productos(Nombre, " +
                    $"Categoria, Talla, Descripcion, Color, Stock, Precio) " +
                    $"VALUES('{p.Nombre}', '{p.Categoria}', '{p.Talla}', '{p.Descripcion}', " +
                    $"'{p.Color}', '{p.Stock}', '{p.Precio}')"));

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
