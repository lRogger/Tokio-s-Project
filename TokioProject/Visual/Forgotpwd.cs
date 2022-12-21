using Individual.Modelos;
using Individual.Visual;
using LibreriaGrupal;
using System.Data;

namespace Individual
{
    public partial class Forgotpwd : Form
    {
        private DataSet ds = new DataSet();
        private DataBase db = new DataBase();
        private int posX = 0, posY = 0;

        public Forgotpwd()
        {
            InitializeComponent();
        }

        private void cedulafpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();

            e.Handled = u.validar((char)e.KeyChar, "numero");
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (newpwd.Text.Trim() != "" && newpwd2.Text.Trim() != "")
            {
                if (newpwd.Text.Trim() == newpwd2.Text.Trim())
                {
                    try
                    {
                        db.instruccionDB("UPDATE personas SET password = '" +
                            BCrypt.Net.BCrypt.HashPassword(newpwd.Text.Trim()) + "' WHERE cedula = '" +
                            cedulafpwd.Text.Trim() + "'");
                        MessageBox.Show("Contraseña cambiada con éxito!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden!");
                    newpwd.Text = "";
                    newpwd2.Text = "";
                }
            }
            else
            {
                new Emergente("advertencia", "Eror", "Campos vacios!").Show();
            }

        }

        private async void btnValidar_Click(object sender, EventArgs e)
        {
            if (correofpwd.Text != "" && cedulafpwd.Text != "")
            {
                ds.Tables.Clear();
                await Task.Run(() => db.consultar("SELECT * FROM personas WHERE correo = '" +
                correofpwd.Text.ToLower() + "' AND cedula = '" + cedulafpwd.Text + "'"));
                ds = db.Ds;

                if (ds.Tables[0].Rows.Count > 0)
                {
                    btnEnviar.Enabled = true;
                    newpwd.Enabled = true;
                    newpwd2.Enabled = true;
                    MessageBox.Show("Ingresa tu nueva contraseña");

                }
                else
                {
                    MessageBox.Show("No se ha encontrado la cuenta");
                }
            }
            else
            {
                new Emergente("advertencia", "Eror", "Campos vacios!").Show();
            }


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forgotpwd_MouseMove(object sender, MouseEventArgs e)
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
