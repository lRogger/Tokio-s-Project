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

namespace Individual.Visual
{
    public partial class MantenimientoUsuario : Form
    {
        

        public MantenimientoUsuario()
        {
            InitializeComponent();
            DataSet ds = Utilidades.consultar("SELECT cedula, nombre, correo, edad from personas");
            usersDGV.DataSource = ds.Tables[0];


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buscarUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                DataSet ds = Utilidades.consultar("SELECT cedula, nombre, " +
                    "correo, edad FROM personas WHERE nombre like '%"+buscarUser.Text.Trim()+"%'");
                usersDGV.DataSource = ds.Tables[0];
            }
        }
    }
}
