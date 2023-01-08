using Datos;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using TokiosProject.Visual;

namespace Individual.Visual
{
    public partial class FrmPrincipal : Form
    {
        private DataBase db = new DataBase();
        private Login lg;
        private int posX = 0, posY = 0;
        MantenimientoUsuario mu;


        public FrmPrincipal(Login lg)
        {
            InitializeComponent();
            this.lg = lg;
            mu = new MantenimientoUsuario();

        }




        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }


        }




        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
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
                lg.Show();
                lg.tbpwd.Enabled = true;
                lg.tbUser.Enabled = true;
                lg.btnIniciar.Enabled = true;
                this.Close();

            }
            else
            {
                // Do something  
            }
        }

        private void menuStrip_MouseMove(object sender, MouseEventArgs e)
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

        private void toolStrip_MouseMove(object sender, MouseEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
 
        }

        //MÉTODO PARA EDITAR USUARIO
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NewUser nu = new NewUser();
            nu.cedUser.Text = lg.ds.Tables[0].Rows[0]["Cedula"].ToString();
            nu.cedUser.Enabled = false;

            nu.nomUser.Text = lg.ds.Tables[0].Rows[0]["Nombre"].ToString();
            nu.correoUser.Text = lg.ds.Tables[0].Rows[0]["Correo"].ToString();
            nu.edadUser.Text = lg.ds.Tables[0].Rows[0]["Edad"].ToString();
            nu.admUser.Checked = (lg.ds.Tables[0].Rows[0]["Admin"].ToString() == "True")
                ? true : false;

            nu.admUser.Enabled = false;

            MemoryStream ms = new MemoryStream((byte[])lg.ds.Tables[0].Rows[0]["Imagen"]);
            Image img = Image.FromStream(ms);
            nu.fotoUser.Image = img;

            if (nu.ShowDialog() != DialogResult.Abort)
            {
                new Emergente("advertencia", "Datos cambiados", "Proceso exitoso, los cambios se aplicarán en la siguiente sesión").ShowDialog();

            }
            else
            {
                new Emergente("advertencia", "Error", "Operación no completada!");
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream((byte[])lg.ds.Tables[0].Rows[0]["Imagen"]);
                Image img = Image.FromStream(ms);
                profileP.Image = img;
                lblSesion.Text = "Sesión actual: " + lg.ds.Tables[0].Rows[0]["Nombre"].ToString();
            }
            catch
            {
                profileP.ImageLocation = "../../../../data/Img/defaultAvatar.png";
                
            }
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePwd changePW = new ChangePwd(lg.ds);
            changePW.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //ABRIR VENTANA PARA CRUD PERSONAS
        private void mantenimientoPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(mu.IsDisposed)
            {
                mu = new MantenimientoUsuario();
            }
            mu.TopLevel = false;
            this.panelPrincipal.Controls.Add(mu);
            mu.Show();
        }

    }
}
