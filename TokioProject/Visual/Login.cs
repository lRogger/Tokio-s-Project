using Entidades;
using Datos;
using Individual.Visual;
using LibreriaGrupal;
using System.Data;

namespace Individual
{
    public partial class Login : Form
    {
        private int posX = 0, posY = 0;
       
public DataSet ds = new DataSet();
        private DataBase db = new DataBase();

        public Login()
        {
            InitializeComponent();
     
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

                    //Cursor.Current = Cursors.Hand;
                    await Task.Run(() => db.consultar("SELECT * FROM Personas WHERE Cedula = '" + tbUser.Texts.Trim() + "'"));
                    ds.Tables.Clear();
                    ds = db.Ds;
                    //Cursor.Current = Cursors.Default;

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (BCrypt.Net.BCrypt.Verify(tbpwd.Texts.Trim(), ds.Tables[0].Rows[0]["Password"].ToString()))
                        {
                            FrmPrincipal frmp = new FrmPrincipal(this);
                            if (ds.Tables[0].Rows[0]["Admin"] is true)
                            {
                                frmp.adminMenu.Visible = true;
                            }
                            frmp.Show();
                            this.Hide();
                            tbpwd.Texts = "";
                            tbUser.Texts = "";

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
                    MessageBox.Show(ex.ToString());
                    tbpwd.Texts = "";
                    tbUser.Texts = "";
                }

            }
            else
            {
                MessageBox.Show("Campos vacios!");
            }
        }

        private void pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
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

        private void tbUser__TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();
            e.Handled = u.validar((char)e.KeyChar, "numero");
        }

        private void rjTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                ingresar();
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

    }
}
