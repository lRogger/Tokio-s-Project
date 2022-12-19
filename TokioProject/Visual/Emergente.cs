using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual.Visual
{
    public partial class Emergente : Form
    {
        private string tipo;
        private string titulo;
        private string mensaje;

        public Emergente(string tipo, string titulo, string mensaje)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.titulo = titulo;
            this.mensaje = mensaje;
        }

        private void Emergente_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = titulo;
            lblTexto.Text = mensaje;

            if (tipo == "advertencia")
            {
                int izq, der;
                izq = btnOk.Margin.Left + btnCancel.Margin.Left + (btnCancel.Width / 2);
                der = btnOk.Margin.Right + btnCancel.Margin.Right + (btnCancel.Width / 2);
                
                btnOk.Text = "OK";

                btnOk.Margin = new Padding((izq), (btnOk.Margin.Top), der, btnOk.Margin.Bottom);
                btnCancel.Hide();

            }else if(tipo == "si/no")
            {

            }else if(tipo == "espera"){

                flPanel.Visible = false;
            }
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
