using Datos;
using Entidades;
using GUIs.Visual;
using System.Diagnostics;
using TokiosProject.Visual;

namespace Individual.Visual
{
    public partial class FrmPrincipal : Form
    {
        private DataBase db = new DataBase();
        private Login lg;
        private int posX = 0, posY = 0;
        MantenimientoProducto mp;
        private Persona sesion;


        public FrmPrincipal(Persona sesion)
        {
            InitializeComponent();
            this.sesion = sesion;
            mp = new MantenimientoProducto();
            menuConfig.IsMainMenu= true;

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
            mp = new MantenimientoProducto();
            mp.TopLevel = false;
            this.panelPrincipal.Controls.Add(mp);
            mp.Show();
            lblSesion.Text = sesion.Nombre;
            try
            {
                MemoryStream ms = new MemoryStream(sesion.Foto);
                Image img = Image.FromStream(ms);
                profileP.Image = img;
                
            }
            catch
            {
                
                //profileP.ImageLocation = "../../../Data/Img/defaultAvatar.png";
                
            }
        }


        private void MantenimientoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            mp.Show();
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
            mp.Show();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            menuConfig.Show(btnConfig,btnConfig.Width,0);
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
            nu.cedUser.Text = sesion.Cedula;
            nu.cedUser.Enabled = false;

            nu.nomUser.Text = sesion.Nombre;
            nu.correoUser.Text = sesion.Correo;
            nu.edadUser.Text = sesion.Edad.ToString();
            nu.admUser.Checked = sesion.Admin;
               

            nu.admUser.Enabled = false;

            if(sesion.Foto != null )
            {
                MemoryStream ms = new MemoryStream(sesion.Foto);
                Image img = Image.FromStream(ms);
                nu.fotoUser.Image = img;
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

        private void cambiarContraseñaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangePwd changePW = new ChangePwd(sesion);
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

        private void VentanaUsuarios()
        {
            MantenimientoUsuario mu = new MantenimientoUsuario();
            mu.FormClosed += MantenimientoUsuario_FormClosed;


            mu.TopLevel = false;
            mp.Hide();
            this.panelPrincipal.Controls.Add(mu);
            mu.Show();
        }

    }
}
