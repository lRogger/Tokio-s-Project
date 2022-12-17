using Individual.Visual;
using LibreriaGrupal;
using System.Data;
using System.Windows.Forms;

namespace Individual
{
    public partial class Login : Form
    {
        private int posX = 0, posY = 0;
        public DataSet ds;

        public Login()
        {
            InitializeComponent();
            this.cerrar.Parent = this.pictureBox1;
            
        }

        private void ingresar()
        {
            if (pwd.Text != "" && user.Text != "")
            {
                try
                {
                    ds = Utilidades.consultar("SELECT * FROM personas WHERE cedula = '" + user.Text.Trim() + "'");

                    if (BCrypt.Net.BCrypt.Verify(pwd.Text.Trim(), ds.Tables[0].Rows[0]["password"].ToString()))
                    {
                        MessageBox.Show("Sesion iniciada, bienvenido " + ds.Tables[0].Rows[0]["nombre"]);
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
                        MessageBox.Show("Contraseña incorrecta!");
                        pwd.Text = "";
                    }


                }
                catch
                {
                    MessageBox.Show("Nombre de usuario no encontrado");
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
            fg.Show();
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

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pwd_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
