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

        //Evento load
        private void MantenimientoProveedor_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        //Eventos click de las opciones del módulo (crear, editar, eliminar y refrescar)
        private void btnCrear_Click(object sender, EventArgs e)
        {
            NewProveedor proveedor = new NewProveedor();
            proveedor.ShowDialog();
            if (proveedor.Guardado)
            {
                CargarTabla();
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (proveedoresDGV.SelectedCells.Count > 0)
            {
                int selected = proveedoresDGV.CurrentRow.Index;

                NewProveedor proveedor = new NewProveedor();
                proveedor.cedProveedor.Enabled = false;

                proveedor.nomProveedor.Text = (string)proveedoresDGV.Rows[selected].Cells[1].Value;
                proveedor.cedProveedor.Text = (string)proveedoresDGV.Rows[selected].Cells[2].Value;
                proveedor.correoProveedor.Text = (string)proveedoresDGV.Rows[selected].Cells[3].Value;
                proveedor.telefProveedor.Text = (string)proveedoresDGV.Rows[selected].Cells[4].Value;

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
                                                          "Está seguro de eliminar el proveedor? \n\n Este proceso es irreversible"
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
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }
        //----------------------------------------------------------------------------------------------------------------------------

        //Evento textChanged para buscar en la tabla

        private void buscarProveedor_TextChanged(object sender, EventArgs e)
        {
            busquedaDGV(buscarProveedor.Text.ToLower());
        }
        //----------------------------------------------------------------------------------------------------------------------------

        //Metodo de cargar datos en la tabla
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

        //Metodo con algoritmo de busqueda
        private void busquedaDGV(string entrada)
        {
            proveedoresDGV.ClearSelection();
            
            foreach(DataGridViewRow row in proveedoresDGV.Rows)
            {
                string nombre = ((string)row.Cells[1].Value).ToLower();
                string cedula_ruc = ((string)row.Cells[2].Value).ToLower();

                row.Visible = (nombre.Contains(entrada) || cedula_ruc.Contains(entrada))? true : false;
            }
        }
    }
}
