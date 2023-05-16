using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIs.Visual
{
    public partial class DescripcionRegistro : Form
    {
        public DescripcionRegistro(Registros r)
        {
            InitializeComponent();
            lblDescripcionRegistro.Text = r.Descripcion;
            lblIdentificacion.Text = r.Id.ToString();
            lblDia.Text = r.Fecha.ToString("D");
            lblEncargado.Text = r.Usuario.Nombre.ToString();
            lblProducto.Text = r.Producto.Nombre.ToString();
            //lblCantidad.Text = r.Cantidad.ToString();
            this.Height += lblDescripcionRegistro.Height;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panelDescripcionRegistro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
