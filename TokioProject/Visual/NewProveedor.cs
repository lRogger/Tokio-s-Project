using Datos;
using LibreriaGrupal;
using MySql.Data.MySqlClient;
using System.Data;
using Entidades;
using System.Data.SqlClient;

namespace Individual.Visual
{

    public partial class NewProveedor : Form
    {


        private DataBase db = new DataBase();
        int posY = 0, posX = 0;


        public NewProveedor()
        {
            InitializeComponent();

        }

        private void Enviar()
        {
            if (cedProveedor.Text.Trim() != "" && nomProveedor.Text.Trim() != ""
                && correoProveedor.Text.Trim().ToLower() != "" && telefProveedor.Text.Trim() != "")
            {

                MemoryStream ms = new MemoryStream();
                fotoUser.Image.Save(ms, fotoUser.Image.RawFormat);
                byte[] aByte = ms.GetBuffer();

                //Persona p = new Persona(nomProveedor.Text, cedProveedor.Text, correoProveedor.Text,
                //Int32.Parse(telefProveedor.Text), admin, aByte, "");

                this.Hide();

                //new DBPersona().ActualizaUsuario(p);
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


        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!cedProveedor.Enabled)
            {
                Enviar();
            }
            else if (cedProveedor.Enabled)
            {
                if (cedProveedor.Text.Length == 10)
                {
                    if (correoProveedor.Text.IndexOf('@') > -1 && correoProveedor.Text.IndexOf('.') > -1)
                    {
                        DataSet ds = new DataSet();
                        await Task.Run(() => db.consultar($"SELECT Cedula, Correo FROM Personas WHERE Cedula = '{cedProveedor.Text}'" +
                            $" OR Correo = '{correoProveedor.Text}'"));
                        ds = db.Ds;
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                if (ds.Tables[0].Rows[0]["Correo"].ToString() == correoProveedor.Text)
                                {
                                    new Emergente("advertencia", "ERROR", "El correo ya se encuentra registrado").ShowDialog();
                                }
                                if (ds.Tables[0].Rows[0]["Cedula"].ToString() == cedProveedor.Text)
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
                    new Emergente("advertencia", "ERROR", "Formato incorrecto en cédula").ShowDialog();
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
            if (!cedProveedor.Enabled)
            {
                lblTitulo.Text = "Editar Proveedor";
            }

        }



    }
}
