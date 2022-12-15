﻿using LibreriaGrupal;
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

namespace Individual
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
                    DataSet ds = Utilidades.consultar(String.Format("SELECT * FROM personas WHERE " +
                    "cedula='{0}' AND password ='{1}'", user.Text.Trim(), BCrypt.Net.BCrypt.HashPassword(pwd.Text.Trim())));
                    MessageBox.Show("Sesion iniciada!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                
            }
        }
    }
}
