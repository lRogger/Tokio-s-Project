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
            //this.cerrar.Parent = this.pictureBox1;
     
            panelMod1.BackColor = Color.FromArgb(25, Color.Black);
        }

        private async void ingresar()
        {

            if (pwd.Text != "" && user.Text != "")
            {

                try
                {
                    pwd.Enabled = false;
                    user.Enabled = false;
                    btnIniciar.Enabled = false;

                    //Cursor.Current = Cursors.Hand;
                    await Task.Run(() => db.consultar("SELECT * FROM personas WHERE cedula = '" + user.Text.Trim() + "'"));
                    ds.Tables.Clear();
                    ds = db.Ds;
                    //Cursor.Current = Cursors.Default;

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
                            btnIniciar.Enabled = true;
                        }
                    }
                    else
                    {
                        new Emergente("advertencia", "ERROR", "Usuario no encontrado").ShowDialog();
                        pwd.Enabled = true;
                        user.Enabled = true;
                        btnIniciar.Enabled = true;
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

        private void btnIniciar_Click(object sender, EventArgs e)
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
