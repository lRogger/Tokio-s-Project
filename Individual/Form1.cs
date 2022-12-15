
using LibreriaGrupal;
using System.Data;
using System.Windows.Forms;

namespace Individual

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string message = "Seguro que desea salir del programa?";
            string title = "Cerrar Ventana";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine((char)Keys.Back);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();

            e.Handled = u.validar((char)e.KeyChar, "numero");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = Utilidades.consultar("SELECT * FROM personas");
            prueba.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = Utilidades.consultar("SELECT * FROM comida");
            prueba.DataSource = ds.Tables[0];
        }
    }
} 