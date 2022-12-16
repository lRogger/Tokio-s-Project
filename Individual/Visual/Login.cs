using LibreriaGrupal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Generators;
using Individual.Visual;

namespace Individual
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.cerrar.Parent = this.pictureBox1;
        }

        private void pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades u = new Utilidades();

            e.Handled = u.validar((char)e.KeyChar, "numero");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pwd.Text != "" && user.Text != "")
            {
                try
                {
                    DataSet ds = Utilidades.consultar("SELECT * FROM personas WHERE cedula = '"+user.Text.Trim()+"'");

                    if (BCrypt.Net.BCrypt.Verify(pwd.Text.Trim(), ds.Tables[0].Rows[0]["password"].ToString()))
                    {
                        MessageBox.Show("Sesion iniciada, bienvenido " + ds.Tables[0].Rows[0]["nombre"]);
                        Form1 f1 = new Form1();
                        f1.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta!");
                    }
                    
                    
                }
                catch
                {
                    MessageBox.Show("Nombre de usuario no encontrado");
                }
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgotpwd fg = new Forgotpwd();
            fg.Show();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwd_Enter(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
