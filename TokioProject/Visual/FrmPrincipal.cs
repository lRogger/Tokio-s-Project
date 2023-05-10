using Datos;
using Entidades;
using GUIs.Properties;
using GUIs.Visual;
using System.Diagnostics;
using TokiosProject.Visual;

namespace Individual.Visual
{
    public partial class FrmPrincipal : Form
    {
        private int posX = 0, posY = 0;
        MantenimientoProducto mp;
        private Persona sesion;
        MantenimientoUsuario mu = new MantenimientoUsuario();
        RegistroHistorial rh = new RegistroHistorial();

        public Persona Sesion { get => sesion; set => sesion = value; }

        public FrmPrincipal(Persona sesion)
        {
            InitializeComponent();
            this.sesion = sesion;
            mp = new MantenimientoProducto();
            menuConfig.IsMainMenu = true;

        }


        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {

                childForm.Close();

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


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            VentanaProductos();
            lblSesion.Text = Sesion.Nombre;
            profileP.Image = (Sesion.Foto != null)
                ? Image.FromStream(new MemoryStream(Sesion.Foto))
                : Resources.defaultAvatar;
        }


        private void MantenimientoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            VentanaProductos();
        }

        private void RegistroHistorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            VentanaProductos();
        }

        private void VentanaProductos()
        {
            if (mp.IsDisposed)
            {
                mp = new MantenimientoProducto();
            }

            mp.TopLevel = false;
            this.panelPrincipal.Controls.Clear();
            this.panelPrincipal.Controls.Add(mp);
            try
            {
                if (!mp.IsDisposed)
                {
                    mp.Show();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            menuConfig.Show(btnConfig, btnConfig.Width, 0);
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            VentanaProductos();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            VentanaUsuarios();

        }

        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser();
            nu.cedUser.Text = Sesion.Cedula;
            nu.cedUser.Enabled = false;

            nu.nomUser.Text = Sesion.Nombre;
            nu.correoUser.Text = Sesion.Correo;
            nu.edadUser.Text = Sesion.Edad.ToString();
            nu.admUser.Checked = Sesion.Admin;


            nu.admUser.Enabled = false;

            nu.fotoUser.Image = (Sesion.Foto != null)
                 ? Image.FromStream(new MemoryStream(Sesion.Foto))
                 : profileP.Image = Resources.defaultAvatar;


            if (nu.ShowDialog() != DialogResult.Abort)
            {
                new Emergente("advertencia", "Datos cambiados", "Proceso exitoso").ShowDialog();
                profileP.Image = nu.fotoUser.Image;
            }
            else
            {
                new Emergente("advertencia", "Error", "Operación no completada!");
            }
        }

        private void cambiarContraseñaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangePwd changePW = new ChangePwd(Sesion);
            changePW.ShowDialog();
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

        private void btnConfig_Click(object sender, EventArgs e)
        {

        }
        private void VentanaRegistros()
        {
            //RegistroHistorial rh = new RegistroHistorial();

            rh.FormClosed += RegistroHistorial_FormClosed;
            rh.TopLevel = false;
            mp.Hide();
            mu.Hide();
            this.panelPrincipal.Controls.Add(rh);

            rh.Show();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            VentanaRegistros();
        }

        private void VentanaUsuarios()
        {
            if (mu.IsDisposed)
            {
                mu = new MantenimientoUsuario();
            }

            mu.FormClosed += MantenimientoUsuario_FormClosed;
            mu.TopLevel = false;
            rh.Hide();
            mp.Hide();
            this.panelPrincipal.Controls.Add(mu);

            mu.Show();
        }

    }
}
