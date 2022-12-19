using Individual.Modelos;
using Individual.Visual;
using LibreriaGrupal;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual
{
    public partial class Forgotpwd : Form
    {
        private DataSet ds = new DataSet();
        private DataBase db = new DataBase();

        public Forgotpwd()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cedulafpwd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cedulafpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();

            e.Handled = u.validar((char)e.KeyChar, "numero");
        }

        private void BtnValidarFp_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void enviar_Click(object sender, EventArgs e)
        {

            
            
        }

        private void newpwd2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Forgotpwd_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(newpwd.Text.Trim()!="" &&  newpwd2.Text.Trim() != "")
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
            if(correofpwd.Text!="" && cedulafpwd.Text != ""){
                await Task.Run(() => db.consultar("SELECT * FROM personas WHERE cedula = '" +
                correofpwd.Text.ToLower() + "' AND correo = '" + cedulafpwd.Text));
                ds = db.Ds;

                if (ds.Tables.Count > 0)
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
    }
}
