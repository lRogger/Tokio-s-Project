using Datos;
using Individual.Visual;
using LibreriaGrupal;
using System.Data;
using System.Diagnostics;

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
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                e.Handled = true;
                Validar();
            }
        }

        private async void CambiarPass()
        {
            if (newpwd.Text.Trim() != "" && newpwd2.Text.Trim() != "")
            {
                if (newpwd.Text.Trim() == newpwd2.Text.Trim())
                {
                    try
                    {
                        string pwd = BCrypt.Net.BCrypt.HashPassword(newpwd.Text.Trim());
                        await Task.Run(() => db.instruccionDB("UPDATE Personas SET Password = '" + pwd
                             + "' WHERE Cedula = '" +
                            cedulafpwd.Text.Trim() + "'"));
                        Debug.WriteLine(pwd);
                        new Emergente("advertencia", "Hecho", "La contraseña se ha cambiado correctamente").ShowDialog();
                    }
                    catch (Exception ex)
                    {

                        new Emergente("advertencia", "ERROR", "Error: " + ex.Message);
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CambiarPass();

        }

        private void Validar()
        {
            if (correofpwd.Text != "" && cedulafpwd.Text != "")
            {
                ds.Tables.Clear();
                db.consultar("SELECT * FROM Personas WHERE Correo = '" +
                correofpwd.Text.ToLower() + "' AND Cedula = '" + cedulafpwd.Text + "'");
                ds = db.Ds;

                try
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        btnEnviar.Enabled = true;
                        newpwd.Enabled = true;
                        newpwd2.Enabled = true;
                        correofpwd.Enabled = false;
                        cedulafpwd.Enabled = false;
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

        private void btnValidar_Click(object sender, EventArgs e)
        {

            Validar();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newpwd2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                e.Handled = true;
                CambiarPass();
            }
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
