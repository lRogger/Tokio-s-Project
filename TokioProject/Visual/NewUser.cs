using Datos;
using LibreriaGrupal;
using MySql.Data.MySqlClient;
using System.Data;
using Entidades;

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
            abrirImagen.Filter = "JPG files (*.jpg)|*.jpg";

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

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private async void enviar()
        {
            if (cedUser.Text.Trim() != "" && nomUser.Text.Trim() != ""
                && correoUser.Text.Trim().ToLower() != "" && edadUser.Text.Trim() != "")
            {
                bool admin = admUser.Checked;

                MemoryStream ms = new MemoryStream();
                fotoUser.Image.Save(ms, fotoUser.Image.RawFormat);
                byte[] aByte = ms.GetBuffer();

                Persona p = new Persona(nomUser.Text, cedUser.Text, correoUser.Text,
                    Int32.Parse(edadUser.Text), admin, aByte);

                MySqlConnection con = db.conectarDB();

                MySqlCommand comando = new MySqlCommand("actualizaUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(new MySqlParameter("_cedula", p.Cedula));
                comando.Parameters.Add(new MySqlParameter("_nombre", p.Nombre));
                comando.Parameters.Add(new MySqlParameter("_correo", p.Correo.ToLower()));
                comando.Parameters.Add(new MySqlParameter("_edad", p.Edad));
                comando.Parameters.Add(new MySqlParameter("_admin", p.Admin));
                comando.Parameters.Add(new MySqlParameter("_imagen", p.Foto));
                this.Hide();
                await Task.Run(() => comando.ExecuteNonQuery());
                con.Close();
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

        private void edadUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void correoUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void cedUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerrar_Click_1(object sender, EventArgs e)
        {

        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!cedUser.Enabled)
            {
                enviar();
            }
            else if (cedUser.Enabled)
            {
                if(cedUser.Text.Length == 10)
                {
                    if(correoUser.Text.IndexOf('@')>-1 && correoUser.Text.IndexOf('.') > -1)
                    {
                        DataSet ds = new DataSet();
                        await Task.Run(() => db.consultar("SELECT Cedula FROM Personas WHERE Cedula = " + cedUser.Text));
                        ds = db.Ds;
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                new Emergente("advertencia", "ERROR", "La cédula ya se encuentra registrada").ShowDialog();
                            }
                            else
                            {
                                enviar();
                            }
                        }
                        else
                        {
                            enviar();
                        }
                    }
                    else
                    {
                        new Emergente("advertencia", "ERROR", "Formato incorrecto en correo").ShowDialog();
                    }
                    
                }
                else
                {
                    new Emergente("advertencia","ERROR","Formato incorrecto en cédula").ShowDialog();
                }
                
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMod1_MouseMove(object sender, MouseEventArgs e)
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

        private void cedUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();

            e.Handled = u.validar((char)e.KeyChar, "numero");
        }

        private void edadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();

            e.Handled = u.validar((char)e.KeyChar, "numero");
        }

        private void nomUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();

            e.Handled = u.validar((char)e.KeyChar, "letras");
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            if (!cedUser.Enabled)
            {
                lblTitulo.Text = "Editar Usuario";
            }

        }



    }
}
