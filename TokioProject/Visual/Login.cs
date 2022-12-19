using Individual.Modelos;
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
            this.cerrar.Parent = this.pictureBox1;

        }

        private async void ingresar()
        {

            if (pwd.Text != "" && user.Text != "")
            {

                try
                {
                    pwd.Enabled = false;
                    user.Enabled = false;
                    button1.Enabled = false;


                    await Task.Run(() => db.consultar("SELECT * FROM personas WHERE cedula = '" + user.Text.Trim() + "'"));
                    ds.Tables.Clear();
                    ds = db.Ds;

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (BCrypt.Net.BCrypt.Verify(pwd.Text.Trim(), ds.Tables[0].Rows[0]["password"].ToString()))
                        {
                            FrmPrincipal frmp = new FrmPrincipal(this);
                            if (ds.Tables[0].Rows[0]["admin"] is true)
                            {
                                frmp.adminMenu.Visible = true;
                            }
                            frmp.Show();
                            this.Hide();
                            pwd.Text = "";
                            user.Text = "";

                        }
                        else
                        {
                            new Emergente("advertencia", "Error", "Contraseña Incorrecta").ShowDialog();
                            pwd.Text = "";
                            pwd.Enabled = true;
                            user.Enabled = true;
                            button1.Enabled = true;
                        }
                    }
                    else
                    {
                        new Emergente("advertencia", "ERROR", "Usuario no encontrado").ShowDialog();
                        pwd.Enabled = true;
                        user.Enabled = true;
                        button1.Enabled = true;
                        pwd.Text = "";
                        user.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    pwd.Text = "";
                    user.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Campos vacios!");
            }
        }

        private void pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                ingresar();
            }

        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();

            e.Handled = u.validar((char)e.KeyChar, "numero");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresar();
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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
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
