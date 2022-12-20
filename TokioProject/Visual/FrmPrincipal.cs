﻿using Individual.Modelos;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace Individual.Visual
{
    public partial class FrmPrincipal : Form
    {
        private DataBase db = new DataBase();
        private Login lg;
        private int posX = 0, posY = 0;
        plantillaRopa p1 = new plantillaRopa();
        plantillaRopa p2 = new plantillaRopa();
        plantillaRopa p3 = new plantillaRopa();
        plantillaRopa p4 = new plantillaRopa();

        public FrmPrincipal(Login lg)
        {
            InitializeComponent();
            this.lg = lg;

            flPanel.Controls.Add(p1);
            flPanel.Controls.Add(p2);
            flPanel.Controls.Add(p3);
            flPanel.Controls.Add(p4);
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());
            flPanel.Controls.Add(new plantillaRopa());


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
                lg.pwd.Enabled = true;
                lg.user.Enabled = true;
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
            p1.Hide();
            p2.Hide();
            p3.Hide();
            p4.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p1.Show();
            p2.Show();
            p3.Show();
            p4.Show();
        }

        //MÉTODO PARA EDITAR USUARIO
        private async void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NewUser nu = new NewUser();
            nu.cedUser.Text = lg.ds.Tables[0].Rows[0]["cedula"].ToString();
            nu.cedUser.Enabled = false;

            nu.nomUser.Text = lg.ds.Tables[0].Rows[0]["nombre"].ToString();
            nu.correoUser.Text = lg.ds.Tables[0].Rows[0]["correo"].ToString();
            nu.edadUser.Text = lg.ds.Tables[0].Rows[0]["edad"].ToString();
            nu.admUser.Checked = (lg.ds.Tables[0].Rows[0]["admin"].ToString() == "True")
                ? true : false;

            nu.admUser.Enabled = false;

            MemoryStream ms = new MemoryStream((byte[])lg.ds.Tables[0].Rows[0]["imagen"]);
            Image img = Image.FromStream(ms);
            nu.fotoUser.Image = img;

            if (nu.ShowDialog() != DialogResult.Abort)
            {
                new Emergente("advertencia", "Datos cambiados", "Proceso exitoso, los cambios se aplicarán en la siguiente sesión").ShowDialog();
                await Task.Run(() => db.consultar("SELECT * FROM personas WHERE cedula = '" + lg.ds.Tables[0].Rows[0]["cedula"] + "'"));
                lg.ds.Tables.Clear();
                lg.ds = db.Ds;
                this.Refresh();
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
                MemoryStream ms = new MemoryStream((byte[])lg.ds.Tables[0].Rows[0]["imagen"]);
                Image img = Image.FromStream(ms);
                profileP.Image = img;
                lblSesion.Text = "Sesión actual: " + lg.ds.Tables[0].Rows[0]["Nombre"].ToString();
            }
            catch
            {
                profileP.ImageLocation = "../../../../data/Img/defaultAvatar.png";
                
            }
        }


        //ABRIR VENTANA PARA CRUD PERSONAS
        private void mantenimientoPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoUsuario mu = new MantenimientoUsuario();
            mu.Show();
        }

    }
}