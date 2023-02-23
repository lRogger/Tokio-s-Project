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
                    
                    List<Persona> personas = await new DBPersona().LeerPersona(tbUser.Texts);
                    

                    if (personas.Count > 0)
                    {

                        Persona sesion = personas[0];
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
