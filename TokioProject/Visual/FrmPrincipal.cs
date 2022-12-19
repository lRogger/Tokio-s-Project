using LibreriaGrupal;
using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Individual.Modelos;
using Microsoft.VisualBasic.ApplicationServices;

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
            try
            {
                MemoryStream ms = new MemoryStream((byte[])lg.ds.Tables[0].Rows[0]["imagen"]);
                Image img = Image.FromStream(ms);
                profileP.Image = img;
            }
            catch
            {
                profileP.ImageLocation = "../../../../data/Img/defaultAvatar.png";
            }
            


            flPanel.Controls.Add(p1);
            flPanel.Controls.Add(p2);
            flPanel.Controls.Add(p3);
            flPanel.Controls.Add(p4);
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

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
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
                lg.button1.Enabled = true;
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

        private void mantenimientoPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoUsuario mu = new MantenimientoUsuario();
            mu.Show();
        }

    }
}
