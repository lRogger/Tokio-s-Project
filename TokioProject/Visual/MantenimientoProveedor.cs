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
    public partial class MantenimientoProveedor : Form
    {
        DBProveedor dataBase = new DBProveedor();

        public MantenimientoProveedor()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            NewProveedor proveedor = new NewProveedor();
            proveedor.ShowDialog();
            if (proveedor.Guardado)
            {
                CargarTabla();
            }
        }
        private void CargarTabla()
        {
            try
            {
                List<Proveedor> lista = dataBase.CargarDatosProveedores();

                proveedoresDGV.Rows.Clear();
                foreach (Proveedor proveedor in lista)
                {
                    proveedoresDGV.Rows.Add(
                        proveedor.Id, proveedor.Nombre,
                        proveedor.Cedula_ruc, proveedor.Correo,
                        proveedor.Telefono);
                }
            }
            catch (Exception ex)
            {
                new Emergente("advertencia", "ERROR DE EXCEPCIÓN", ex.Message).ShowDialog();
            }
        }

        private void MantenimientoProveedor_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (proveedoresDGV.SelectedCells.Count > 0)
            {
                int selected = proveedoresDGV.CurrentRow.Index;

                NewProveedor proveedor = new NewProveedor();
                proveedor.cedProveedor.Enabled = false;

                proveedor.nomProveedor.Text = proveedoresDGV.Rows[selected].Cells[1].Value.ToString();
                proveedor.cedProveedor.Text = proveedoresDGV.Rows[selected].Cells[2].Value.ToString();
                proveedor.correoProveedor.Text = proveedoresDGV.Rows[selected].Cells[3].Value.ToString();
                proveedor.telefProveedor.Text = proveedoresDGV.Rows[selected].Cells[4].Value.ToString();

                proveedor.ShowDialog();
                if (proveedor.Guardado)
                {
                    CargarTabla();
                }
            }
            else
            {
                new Emergente("advertencia", "AVISO", "Debe seleccionar un proveedor").ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (proveedoresDGV.SelectedCells.Count > 0)
            {
                int selected = proveedoresDGV.CurrentRow.Index;
                string identificacion = (string)proveedoresDGV.Rows[selected].Cells[2].Value;

                DialogResult confirmacion = new Emergente("si / no","CONFIRMACIÓN", 
                                                          "Está seguro de eliminar el proveedor \n Este proceso es irreversible"
                                                          ).ShowDialog();
                if(confirmacion == DialogResult.OK)
                {
                    dataBase.BorrarProveedor(identificacion);
                }
            }
            else
            {
                new Emergente("advertencia", "AVISO", "Debe seleccionar un proveedor").ShowDialog();
            }
        }

        private void buscarProveedor_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
