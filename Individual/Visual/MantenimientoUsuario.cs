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

        int posY = 0, posX = 0;
        public MantenimientoUsuario()
        {
            
            InitializeComponent();
            DataSet ds = Utilidades.consultar("SELECT id, cedula, nombre, correo, edad, imagen from personas WHERE cedula != 0");
            usersDGV.DataSource = ds.Tables[0];
            usersDGV.RowHeadersVisible = false;


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buscarUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                DataSet ds = Utilidades.consultar("SELECT id, cedula, nombre, " +
                    "correo, edad, imagen FROM personas WHERE cedula != 0 and (nombre like '%" + buscarUser.Text.Trim()+"%'" +
                    " or cedula like '%"+buscarUser.Text.Trim()+"%')");
                usersDGV.DataSource = ds.Tables[0];
            }
            
        }

        private void buscarUser_TextChanged(object sender, EventArgs e)
        {
            if (buscarUser.Text == "")
            {
                DataSet ds = Utilidades.consultar("SELECT id, cedula, nombre, correo, edad, imagen from personas WHERE cedula != 0");
                usersDGV.DataSource = ds.Tables[0];
            }
        }

        private void MantenimientoUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
