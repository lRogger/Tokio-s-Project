using Datos;
using Entidades;
using Google.Protobuf.WellKnownTypes;
using Individual.Visual;
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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
            productoDGV.RowHeadersVisible = false;
            CargarTabla();
        }

        private void productoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarTabla()
        {

            try
            {
                double cuenta=0;
                List<Balances> listaBalance = new DBbalance().LeerBalance();
                productoDGV.Rows.Clear();

                for(int i=0; i<listaBalance.Count; i++){
                    productoDGV.Rows.Add(listaBalance[i].Producto, listaBalance[i].Fecha.ToString("D"),
                        Math.Round(listaBalance[i].Valor, 2));
                    cuenta = cuenta + listaBalance[i].Valor;
                    productoDGV.Rows[i].Cells[2].Style.ForeColor = (listaBalance[i].Valor>0)?Color.Green:Color.Red;
                }
                lblTotal.Text = cuenta.ToString("N2");
                if(cuenta > 0)
                {
                    lblTotal.ForeColor = Color.Green;
                }else{
                    lblTotal.ForeColor = Color.Red;
                }
                
            }

            catch (Exception ex)
            {
                new Emergente("advertencia", "ERROR", "Ha ocurrido un error al cargar la base de datos\n " +
                     ex.Message).ShowDialog();
            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}
