using Datos;
using Entidades;
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
    public partial class RegistroHistorial : Form
    {     
        private List<Registros> listaRegistros;

        public RegistroHistorial()
        {
            InitializeComponent();
            listaRegistros= new List<Registros>();
            CargarTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress= true;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private async void CargarTabla()
        {
            try
            {
                btnRefrescar.Enabled = false;


                listaRegistros = await new DBRegistros().LeerRegistros();

                btnRefrescar.Enabled = true;



                registrosDGV.Rows.Clear();

                for (int i = listaRegistros.Count-1; i >= 0; i--)
                {
                    registrosDGV.Rows.Add(listaRegistros[i].Id, listaRegistros[i].Fecha.ToString("d"),
                        listaRegistros[i].Usuario.Nombre, listaRegistros[i].Producto.Nombre, listaRegistros[i].Cantidad);

                }
                
            }

            catch (Exception ex)
            {
                new Emergente("advertencia", "ERROR", "Ha ocurrido un error al conectar con la base de datos\n " +
                     ex.Message).ShowDialog();
            }
        }

        private void registrosDGV_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void VentanaDescripcionRegistro()
        {
            if (registrosDGV.SelectedRows.Count > 0)
            {
                int i = registrosDGV.CurrentRow.Index;

                foreach(Registros r in listaRegistros)
                {
                    if(r.Id == (int)registrosDGV.Rows[i].Cells["ID"].Value){
                        DescripcionRegistro dr = new DescripcionRegistro();
                        dr.lblDescripcionRegistro.Text = r.Descripcion;
                        dr.ShowDialog();
                    }
                }
            }
        }

        private void btnDescripcion_Click(object sender, EventArgs e)
        {
            VentanaDescripcionRegistro();
        }

        private void buscarUser_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscarRegistro.Text.Trim() != "")
            {
                registrosDGV.CurrentCell = null;
                foreach (DataGridViewRow row in registrosDGV.Rows)
                {
                    bool encontrado = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null &&
                            (cell.Value.ToString() + "").ToLower().Contains(tbBuscarRegistro.Text.ToLower()))
                        {
                            encontrado = true;
                            break;
                        }
                    }

                    if (encontrado)
                    {
                        row.Visible = true;
                    }
                    else
                    {

                        row.Visible = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in registrosDGV.Rows)
                {
                    if (!row.Visible)
                    {
                        row.Visible = true;
                    }
                }
            }
        }
    }
}
