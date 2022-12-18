using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Individual.Modelos;
using LibreriaGrupal;
using MySql.Data.MySqlClient;

namespace Individual.Visual
{

    public partial class NewUser : Form
    {
      

        private DataBase db = new DataBase();
        int posY = 0, posX = 0;


        public NewUser()
        {
            InitializeComponent();
        }


        private void buscarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                fotoUser.ImageLocation = abrirImagen.FileName;
                fotoUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void panelMod1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cedUser.Enabled.ToString());
            if (!cedUser.Enabled)
            {
                enviar();
            }else if (cedUser.Enabled)
            {
                DataSet ds = db.consultar("SELECT cedula FROM personas WHERE cedula = " + cedUser.Text);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Cedula ya se encuentra registrada");
                }
                else
                {
                    enviar();
                }
            }


        }

        private void enviar()
        {
            if (cedUser.Text.Trim() != "" && nomUser.Text.Trim() != ""
                && correoUser.Text.Trim() != "" && edadUser.Text.Trim() != "")
            {
                bool admin = admUser.Checked;

                MemoryStream ms = new MemoryStream();
                fotoUser.Image.Save(ms, fotoUser.Image.RawFormat);
                byte[] aByte = ms.GetBuffer();

                Persona p = new Persona(nomUser.Text, cedUser.Text, correoUser.Text,
                    Int32.Parse(edadUser.Text), admin, aByte);

                MySqlCommand comando = new MySqlCommand("actualizaUsuario", db.conectarDB());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(new MySqlParameter("_cedula", p.Cedula));
                comando.Parameters.Add(new MySqlParameter("_nombre", p.Nombre));
                comando.Parameters.Add(new MySqlParameter("_correo", p.Correo));
                comando.Parameters.Add(new MySqlParameter("_edad", p.Edad));
                comando.Parameters.Add(new MySqlParameter("_admin", p.Admin));
                comando.Parameters.Add(new MySqlParameter("_imagen", p.Foto));
                comando.ExecuteNonQuery();
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos Vacios!");
            }
        }


        private void NewUser_MouseMove(object sender, MouseEventArgs e)
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

        private void NewUser_Load(object sender, EventArgs e)
        {

        }



    }
}
