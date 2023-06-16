using Datos;
using LibreriaGrupal;
using Entidades;

namespace Individual.Visual
{

    public partial class NewProveedor : Form
    {
        private DBProveedor dataBase;
        private Utilidades u;
        public bool Guardado = false;
        int posY = 0, posX = 0;

        public NewProveedor()
        {
            InitializeComponent();
            dataBase = new DBProveedor();
            u = new Utilidades();
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
                if (cedProveedor.Enabled == true)
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
                MostrarMensajeEmergente("ERROR DE EXCEPCIÓN", ex.Message);
            }
        }
        private void Nuevo()
        {

            if (u.estaVacio(nomProveedor.Text, cedProveedor.Text, correoProveedor.Text, telefProveedor.Text))
            {
                MostrarMensajeEmergente("AVISO", "Hay campos vacíos");
            }
            else
            {
                Proveedor proveedor = CargarDatosDeFormulario();

                if (dataBase.InsertarProveedor(proveedor))
                {
                    MostrarMensajeEmergente("EXITO", "Proveedor guardado correctamente!");
                    this.Guardado = true;
                    this.Close();
                }
                else
                {
                    MostrarMensajeEmergente("ERROR", "La Cédula/RUC ya se encuentra registrada");
                }
            }
        }

        private void Editar()
        {
            if (fueronModificados(nomProveedor, correoProveedor, telefProveedor))
            {
                Proveedor proveedor = CargarDatosDeFormulario();

                if (dataBase.EditarProveedor(proveedor))
                {
                    MostrarMensajeEmergente("EXITO", "Datos actualizados correctamente!");
                    this.Guardado = true;
                    this.Close();
                }
                else
                {
                    MostrarMensajeEmergente("ERROR", "No se pudo actualizar");
                    this.Close();
                }
            }
            else
            {
                MostrarMensajeEmergente("AVISO", "No hubieron cambios para guardar");
                this.Close();
            }
        }
        private bool fueronModificados(params TextBox[] textBoxs)
        {
            foreach (TextBox textbox in textBoxs)
            {
                if (textbox.Modified)
                {
                    return true;
                }
            }
            return false;
        }
        private Proveedor CargarDatosDeFormulario()
        {
            Proveedor proveedor = new Proveedor();   
            proveedor.Nombre = nomProveedor.Text.Trim();
            proveedor.Cedula_ruc = cedProveedor.Text.Trim();
            proveedor.Correo = correoProveedor.Text.Trim().ToLower();
            proveedor.Telefono = telefProveedor.Text.Trim();
            return proveedor;
        }
        private void MostrarMensajeEmergente(string titulo, string mensaje)
        {
            new Emergente("advertencia", titulo, mensaje).ShowDialog();
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