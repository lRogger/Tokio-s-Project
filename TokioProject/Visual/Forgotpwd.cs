using Datos;
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
                        db.instruccionDB("UPDATE Personas SET Password = '" +
                            BCrypt.Net.BCrypt.HashPassword(newpwd.Text.Trim()) + "' WHERE Cedula = '" +
                            cedulafpwd.Text.Trim() + "'");
                        new Emergente("advertencia", "Hecho", "La contraseña se ha cambiado correctamente").ShowDialog();
                    }
                    catch (Exception ex)
                    {

                        new Emergente("advertencia", "ERROR", "Error: "+ex.Message);
                    }
                    this.Close();
                }
                else
                {
                    new Emergente("advertencia", "ERROR", "Las contraseñas no coinciden!").ShowDialog();
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
                await Task.Run(() => db.consultar("SELECT * FROM Personas WHERE Correo = '" +
                correofpwd.Text.ToLower() + "' AND Cedula = '" + cedulafpwd.Text + "'"));
                ds = db.Ds;

                try
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        btnEnviar.Enabled = true;
                        newpwd.Enabled = true;
                        newpwd2.Enabled = true;
                        new Emergente("advertencia", "Hecho", "Ahora puedes elegir tu nueva contraseña").ShowDialog();

                    }
                    else
                    {
                        new Emergente("advertencia", "ERROR", "No hemos encontrado la cuenta").ShowDialog();
                    }
                }
                catch
                {
                    new Emergente("advertencia", "ERROR", "Problema al conectar con la base de datos\n" +
                        "Intente nuevamente");
                }

                
            }
            else
            {
                new Emergente("advertencia", "Error", "Campos vacios!").Show();
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
