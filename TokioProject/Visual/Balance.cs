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
            balanceDGV.RowHeadersVisible = false;
            CargarTabla();
        }

        private void productoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarTabla()
        {

            try
            {
                double cuenta = 0;
                List<Balances> listaBalance = new DBbalance().LeerBalance();
                balanceDGV.Rows.Clear();

                for (int i = 0; i < listaBalance.Count; i++)
                {
                    balanceDGV.Rows.Add(listaBalance[i].Producto, listaBalance[i].Fecha.ToString("D"),
                        Math.Round(listaBalance[i].Valor, 2));
                    cuenta = cuenta + listaBalance[i].Valor;
                    balanceDGV.Rows[i].Cells[2].Style.ForeColor = (listaBalance[i].Valor > 0) ? Color.Green : Color.Red;
                }
                lblTotal.Text = cuenta.ToString("N2");
                if (cuenta > 0)
                {
                    lblTotal.ForeColor = Color.Green;
                }
                else
                {
                    lblTotal.ForeColor = Color.Red;
                }

            }

            catch (Exception ex)
            {
                new Emergente("advertencia", "ERROR", "Ha ocurrido un error al cargar la base de datos\n " +
                     ex.Message).ShowDialog();
            }

        }

        private void FiltrarRegistros()
        {
            try
            {
                double cuenta = 0;
                DateTime? fechaInicio = null;
                DateTime? fechaFin = null;

                if (!chkInhabilitar.Checked)
                {
                    fechaInicio = dtpFechaInicio.Value;
                    fechaFin = dtpFechaFin.Value;

                    if (fechaInicio > fechaFin)
                    {
                        new Emergente("advertencia", "ERROR", "La fecha de inicio debe ser anterior a la fecha de fin").ShowDialog();
                        return;
                    }
                }

                List<Balances> listaBalance = new DBbalance().LeerBalance();
                List<Balances> listaFiltrada = new List<Balances>();

                foreach (var balance in listaBalance)
                {
                    if ((fechaInicio == null || balance.Fecha >= fechaInicio) &&
                        (fechaFin == null || balance.Fecha <= fechaFin))
                    {
                        listaFiltrada.Add(balance);
                        cuenta += balance.Valor;
                    }
                }

                balanceDGV.Rows.Clear();

                foreach (var balance in listaFiltrada)
                {
                    int rowIndex = balanceDGV.Rows.Add(balance.Producto, balance.Fecha.ToString("D"), Math.Round(balance.Valor, 2));

                    if (balance.Valor > 0)
                    {
                        balanceDGV.Rows[rowIndex].Cells[2].Style.ForeColor = Color.Green;
                    }
                    else if (balance.Valor < 0)
                    {
                        balanceDGV.Rows[rowIndex].Cells[2].Style.ForeColor = Color.Red;
                    }
                }

                lblTotal.Text = cuenta.ToString("N2");

                if (cuenta > 0)
                {
                    lblTotal.ForeColor = Color.Green;
                }
                else if (cuenta < 0)
                {
                    lblTotal.ForeColor = Color.Red;
                }
                else
                {
                    lblTotal.ForeColor = DefaultForeColor;
                }
            }
            catch (Exception ex)
            {
                new Emergente("advertencia", "ERROR", "Ha ocurrido un error al cargar la base de datos\n " + ex.Message).ShowDialog();
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            FiltrarRegistros();
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            FiltrarRegistros();
        }

        private void chkInhabilitar_CheckedChanged(object sender, EventArgs e)
        {
            bool inhabilitar = chkInhabilitar.Checked;

            dtpFechaInicio.Enabled = !inhabilitar;
            dtpFechaFin.Enabled = !inhabilitar;

            if (inhabilitar)
            {
                dtpFechaInicio.Value = DateTime.Today;
                dtpFechaFin.Value = DateTime.Today;
            }

            CargarTabla();
        }


    }
}
