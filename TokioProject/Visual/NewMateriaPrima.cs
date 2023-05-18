using Entidades;
using Individual.Visual;
using Datos;
using MySqlX.XDevAPI.Relational;
using System.Globalization;
using LibreriaGrupal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data;
using System.Drawing;

namespace GUIs.Visual
{
    public partial class NewMateriaPrima : Form
    {
        DataBase dataBase = new DataBase();
        DBProveedor dBProveedor = new DBProveedor();
        private int id;
        int posY = 0, posX = 0;

        public NewMateriaPrima()
        {
            InitializeComponent();
            CargarDatos();
            //db = new DataBase();
            id = -1;

        }

        public NewMateriaPrima(int id)
        {
            InitializeComponent();
            //db = new DataBase();
            this.id = id;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        //Metodos para cargar los comboBox con sus respectivos datos
        private void CargarDatos()
        {
            CargarColores();
            CargarProveedores();
        }

        private void CargarColores()
        {
            var colores = new List<Tuple<int, string>>();

            dataBase.consultar("SELECT idColor, Color FROM Colores;");
            DataTable table = dataBase.Ds.Tables[0];
            
            foreach(DataRow row in table.Rows)
            {
                int idColor = (System.Int16)row["idColor"];
                string color = (string)row["Color"];

                colores.Add(new Tuple<int, string>(idColor, color));
            }

            var colorElegir = new Tuple<int, string>(0, "Elija un color..."); //Valor por defecto, elija un color...
            colores.Insert(0, colorElegir);

            cmbColor.DataSource = colores;
            cmbColor.DisplayMember = "Item2";
            cmbColor.ValueMember = "Item1";

            //Activar campo de busqueda
            cmbColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbColor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void CargarProveedores()
        {
            var proveedores = dBProveedor.CargarDatosProveedores();

            var proveedorElegir = new Proveedor
            {
                Id = 0,
                Nombre = "Elija un proveedor...", //Valor por defecto, elija un proveedor...
                Cedula_ruc = string.Empty,
                Correo = string.Empty,
                Telefono = string.Empty
            };

            for (int i = proveedores.Count - 1; i >= 0; i--)
            {
                Proveedor proveedor = proveedores[i];
                if (!proveedor.Activo)
                {
                    proveedores.RemoveAt(i); //Remover proveedores que no están activos
                }
            }
            proveedores.Insert(0, proveedorElegir);

            cmbProveedor.DataSource = proveedores;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Cedula_ruc";

            //Activar campo de busqueda
            cmbProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        //Eventos keypress para validar los campos----------------------------
        private void tbNombreProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();
            e.Handled = u.validar((char)e.KeyChar, "letras");
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
        //----------------------------------------------------------------------

        //Evento para mover la ventana
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
