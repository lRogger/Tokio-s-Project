using Entidades;
using Datos;
using Individual.Visual;
using LibreriaGrupal;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.Logging;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using CustomControls.RJControls;

namespace Individual
{
    public partial class Login : Form
    {
        private int posX = 0, posY = 0;
        private DataSet ds = new DataSet();
        private DataBase db = new DataBase();

        public DataSet Ds { get => ds; set => ds = value; }

        public Login()
        {
            InitializeComponent();

            //Opacidad
            panelMod1.BackColor = Color.FromArgb(110, Color.Black);
            


        }

        private async void ingresar()
        {

            if (tbpwd.Texts != "" && tbUser.Texts != "")
            {

                try
                {
                    tbpwd.Enabled = false;
                    tbUser.Enabled = false;
                    btnIniciar.Enabled = false;

                    await Task.Run(() => db.consultar("SELECT * FROM Personas WHERE Cedula = '" + tbUser.Texts.Trim() + "'"));
                    Ds.Tables.Clear();
                    Ds = db.Ds;

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        Persona sesion = new Persona();
                        sesion.Id = (int)Ds.Tables[0].Rows[0]["Id"];
                        sesion.Cedula = (string)Ds.Tables[0].Rows[0]["Cedula"];
                        sesion.Nombre = (string)Ds.Tables[0].Rows[0]["Nombre"];
                        sesion.Correo = (string)Ds.Tables[0].Rows[0]["Correo"];
                        sesion.Admin = (bool)Ds.Tables[0].Rows[0]["Admin"];
                        sesion.Foto = (byte[])Ds.Tables[0].Rows[0]["Imagen"];
                        sesion.Password = (string)Ds.Tables[0].Rows[0]["Password"];
                        if (BCrypt.Net.BCrypt.Verify(tbpwd.Texts, sesion.Password))
                        {

                            FrmPrincipal frmp = new FrmPrincipal(sesion);
                            if (sesion.Admin)
                            {
                                frmp.btnUsuarios.Visible = true;
                                frmp.lblAdmin.Visible = true;
                                frmp.btnRegistros.Visible = true;
                            }
                            frmp.Show();
                            this.Hide();
                            frmp.FormClosed += (s, args) =>
                            {
                                tbpwd.Enabled = true;
                                tbUser.Enabled = true;
                                btnIniciar.Enabled = true;
                                this.Show();
                            };
                            tbpwd.Texts = "";
                            //tbUser.Texts = "";

                        }
                        else
                        {
                            new Emergente("advertencia", "Error", "Contraseña Incorrecta").ShowDialog();
                            tbpwd.Texts = "";
                            tbpwd.Enabled = true;
                            tbUser.Enabled = true;
                            btnIniciar.Enabled = true;
                        }
                    }
                    else
                    {
                        new Emergente("advertencia", "ERROR", "Usuario no encontrado").ShowDialog();
                        tbpwd.Enabled = true;
                        tbUser.Enabled = true;
                        btnIniciar.Enabled = true;
                        tbpwd.Texts = "";
                        tbUser.Texts = "";
                    }

                }
                catch (Exception ex)
                {
                    new Emergente("advertencia", "ERROR", "Problema al conectar la base de datos \n"
                        +ex.Message).ShowDialog();
                    tbpwd.Enabled = true;
                    tbUser.Enabled = true;
                    btnIniciar.Enabled = true;
                    tbpwd.Texts = "";
                    tbUser.Texts = "";
                }

            }
            else
            {
                new Emergente("advertencia", "ERROR", "Campos vacíos!").ShowDialog();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgotpwd fg = new Forgotpwd();
            fg.ShowDialog();
        }



        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(e);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(e);
        }

        private void panelMod1_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(e);
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();
            e.Handled = u.validar((char)e.KeyChar, "numero");
            if (tbUser.Texts.Length >= 10 && !char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void rjTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                e.Handled = true;
                ingresar();
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        private void MoverVentana(MouseEventArgs e)
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
