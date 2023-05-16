using Datos;
using LibreriaGrupal;
using MySql.Data.MySqlClient;
using System.Data;
using Entidades;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;
using Controladores;

namespace Individual.Visual
{

    public partial class NewProveedor : Form
    {
        CtrlProveedor control = new CtrlProveedor();
        Utilidades u = new Utilidades();

        int posY = 0, posX = 0;
        public bool Guardado = false;

        public NewProveedor()
        {
            InitializeComponent();
        }

        //Evento load
        private void NewUser_Load(object sender, EventArgs e)
        {
            if (!cedProveedor.Enabled)
            {
                lblTitulo.Text = "Editar Proveedor";
            }
        }

        //Eventos clicks de los botones
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cedProveedor.Enabled == true)
                {
                    Nuevo();
                }
                else
                {
                    Editar();
                }
            }
            catch (Exception ex)
            {
                new Emergente("advertencia", "ERROR DE EXCEPCIÓN", ex.Message).ShowDialog();
            }
        }
        private void Nuevo()
        {
            if (u.estaVacio(nomProveedor.Text, cedProveedor.Text, correoProveedor.Text, telefProveedor.Text))
            {
                new Emergente("advertencia", "AVISO", "Hay campos vacíos").ShowDialog();
            }
            else
            {
                if (control.GuardarProveedor(nomProveedor.Text, cedProveedor.Text, correoProveedor.Text, telefProveedor.Text))
                {
                    Guardado = true;
                    new Emergente("advertencia", "EXITO", "Proveedor guardado correctamente!").ShowDialog();
                    this.Close();
                }
                else
                {
                    new Emergente("advertencia", "ERROR", "La Cédula/RUC ya se encuentra registrada").ShowDialog();
                }
            }
        }

        private void Editar()
        {
            if (fueronModificados(nomProveedor, correoProveedor, telefProveedor))
            {
                if (control.EditarProveedor(nomProveedor.Text, cedProveedor.Text, correoProveedor.Text, telefProveedor.Text))
                {
                    Guardado = true;
                    new Emergente("advertencia", "EXITO", "Datos actualizados correctamente!").ShowDialog();
                    this.Close();
                }
                else
                {
                    new Emergente("advertencia", "ERROR", "No se pudo actualizar").ShowDialog();
                    this.Close();
                }
            }
            else
            {
                new Emergente("advertencia", "AVISO", "No hubieron cambios para guardar").ShowDialog();
                this.Close();
            }
        }
        private bool fueronModificados(params TextBox[] textBoxs)
        {
            foreach(TextBox textbox in textBoxs)
            {
                if (textbox.Modified)
                {
                    return true;
                }
            }
            return false;
        }

        //Eventos keypress para validaciones
        private void cedProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = u.validar((char)e.KeyChar, "numero");
        }

        private void nomProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = u.validar((char)e.KeyChar, "letras");
        }

        private void telefProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = u.validar((char)e.KeyChar, "numero");
        }

        //Eventos mouse move para poder mover la ventana
        private void NewUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
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
        private void panelMod1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
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
    }
}