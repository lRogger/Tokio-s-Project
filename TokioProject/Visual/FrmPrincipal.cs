﻿using Datos;
using Entidades;
using GUIs.Visual;
using System.Diagnostics;
using TokiosProject.Visual;

namespace Individual.Visual
{
    public partial class FrmPrincipal : Form
    {
        private int posX = 0, posY = 0;
        private Persona sesion;
        private Button activeButton;

        Form activeForm;

        public Persona Sesion { get => sesion; set => sesion = value; }

        public FrmPrincipal(Persona sesion)
        {
            InitializeComponent();
            this.sesion = sesion;
            menuConfig.IsMainMenu = true;
            SetActiveButton(btnProductos);
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LoadFormInPanel(new MantenimientoProducto(), panelPrincipal, ref activeForm);
            lblSesion.Text = Sesion.Nombre;
            try
            {
                profileP.ImageLocation = Sesion.Foto;
            }
            catch
            {
                //profileP.ImageLocation = "../../../Data/Img/defaultAvatar.png";
            }
        }

        //Método para cargar forms en el panel principal
        public static void LoadFormInPanel(Form form, Panel panel, ref Form activeForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.BringToFront();
            form.Show();
        }
        //Eventos click de cada menu
        private void btnConfig_Click_1(object sender, EventArgs e)
        {
            menuConfig.Show(btnConfig, btnConfig.Width, 0);
        }
        private void btnRegistros_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnRegistros);
            if (!(activeForm is RegistroHistorial))
            {
                LoadFormInPanel(new RegistroHistorial(), panelPrincipal, ref activeForm);
            }
        }

        private void btnCommodities_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnCommodities);
            if (!(activeForm is MantenimientoMateriaPrima))
            {
                LoadFormInPanel(new MantenimientoMateriaPrima(), panelPrincipal, ref activeForm);
            }
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnProveedores);
            if (!(activeForm is MantenimientoProveedor))
            {
                LoadFormInPanel(new MantenimientoProveedor(), panelPrincipal, ref activeForm);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnProductos);
            if (!(activeForm is MantenimientoProducto))
            {
                LoadFormInPanel(new MantenimientoProducto(), panelPrincipal, ref activeForm);
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnUsuarios);
            if (!(activeForm is MantenimientoUsuario))
            {
                LoadFormInPanel(new MantenimientoUsuario(), panelPrincipal, ref activeForm);
            }
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnBalance);
            if (!(activeForm is Balance))
            {
                LoadFormInPanel(new Balance(), panelPrincipal, ref activeForm);
            }
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            string mensaje = "Está seguro que desea cerrar la sesión actual?";
            string titulo = "Cerrar Sesión";
            DialogResult result = new Emergente("si/no", titulo, mensaje).ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();

            }
        }
        //-----------------------------------------------------------------------------------
        private void cambiarContraseñaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangePwd changePW = new ChangePwd(Sesion);
            changePW.ShowDialog();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {

                childForm.Close();

            }
        }

        private void SetActiveButton(Button button)
        {
            if (activeButton != null)
            {
                // Restaurar el color original del botón activo anterior
                activeButton.BackColor = Color.FromArgb(128, 27, 141);
            }

            // Establecer el nuevo botón activo y cambiar su color de fondo
            activeButton = button;
            activeButton.BackColor = Color.FromArgb(128, 0, 128);
        }
        private void MoverVentana(MouseEventArgs e)
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
        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser();
            nu.cedUser.Text = Sesion.Cedula;
            nu.cedUser.Enabled = false;

            nu.nomUser.Text = Sesion.Nombre;
            nu.correoUser.Text = Sesion.Correo;
            nu.dtpFechaNac.Value = Sesion.Edad.Date;
            nu.admUser.Checked = Sesion.Admin;

            nu.admUser.Enabled = false;

            if (Sesion.Foto != null)
            {

                nu.fotoUser.ImageLocation = Sesion.Foto;
            }
            if (nu.ShowDialog() != DialogResult.Abort)
            {
                new Emergente("advertencia", "Datos cambiados", "Proceso exitoso, los cambios se aplicarán en la siguiente sesión").ShowDialog();

            }
            else
            {
                new Emergente("advertencia", "Error", "Operación no completada!");
            }
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(e);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(e);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(e);
        }
        private void flowLayoutPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(e);
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(e);
        }
        private void lblSesion_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(e);
        }
    }
}