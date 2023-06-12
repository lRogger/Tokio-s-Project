using Datos;
using LibreriaGrupal;
using MySql.Data.MySqlClient;
using System.Data;
using Entidades;
using System.Data.SqlClient;

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


        private async void Enviar()
        {
            if (cedUser.Text.Trim() != "" && nomUser.Text.Trim() != ""
                && correoUser.Text.Trim().ToLower() != "" && dtpFechaNac.Text.Trim() != "")
            {
                bool admin = admUser.Checked;

                MemoryStream ms = new MemoryStream();
                fotoUser.Image.Save(ms, fotoUser.Image.RawFormat);
                byte[] aByte = ms.GetBuffer();
                Imgur foto = new Imgur();
                string fotoUsu = await foto.SubirImagen(aByte);

                Persona p = new Persona(nomUser.Text, cedUser.Text, correoUser.Text,
                    dtpFechaNac.Value.Date, admin, fotoUsu, "");


                
                this.Hide();

                new DBPersona().ActualizaUsuario(p);
                this.Close();
                
            }
            else
            {
                new Emergente("advertencia", "ERROR", "Hay campos vacíos");
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


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!cedUser.Enabled)
            {
                Enviar();
            }
            else if (cedUser.Enabled)
            {
                if(cedUser.Text.Length == 10)
                {
                    if(correoUser.Text.IndexOf('@')>-1 && correoUser.Text.IndexOf('.') > -1)
                    {
                        DataSet ds = new DataSet();
                        db.consultar($"SELECT Cedula, Correo FROM Personas WHERE Cedula = '{cedUser.Text}'" +
                            $" OR Correo = '{correoUser.Text}'" );
                        ds = db.Ds;
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                if (ds.Tables[0].Rows[0]["Correo"].ToString() == correoUser.Text)
                                {
                                    new Emergente("advertencia", "ERROR", "El correo ya se encuentra registrado").ShowDialog();
                                }
                                if (ds.Tables[0].Rows[0]["Cedula"].ToString() == cedUser.Text)
                                {
                                    new Emergente("advertencia", "ERROR", "La cédula ya se encuentra registrada").ShowDialog();
                                }
                                
                            }
                            else
                            {
                                Enviar();
                            }
                        }
                        else
                        {
                            Enviar();
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

        /*
        private void edadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();

            e.Handled = u.validar((char)e.KeyChar, "numero");
        }
        */

        private void nomUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();

            e.Handled = u.validar((char)e.KeyChar, "letras");
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
