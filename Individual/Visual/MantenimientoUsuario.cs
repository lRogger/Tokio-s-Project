using Individual.Modelos;
using Individual.Visual.ComponentesMod;
using Microsoft.VisualBasic;
using System.Data;
using System.Windows.Forms;


namespace Individual.Visual
{
    public partial class MantenimientoUsuario : Form
    {

        int posY = 0, posX = 0;
        private DataBase db = new DataBase();


        public MantenimientoUsuario()
        {
            
            InitializeComponent();
            DataSet ds = db.consultar("SELECT id, cedula, nombre, correo, edad, imagen from personas WHERE cedula != 0");
            usersDGV.DataSource = ds.Tables[0];
            usersDGV.RowHeadersVisible = false;

            usersDGV.RowTemplate.Height = usersDGV.Columns[5].Width;

            DataGridViewImageColumn dgvImagen = (DataGridViewImageColumn)usersDGV.Columns[5];

            dgvImagen.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dgvImagen.DefaultCellStyle.NullValue = null;
            


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buscarUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                DataSet ds = db.consultar("SELECT id, cedula, nombre, " +
                    "correo, edad, imagen FROM personas WHERE cedula != 0 and (nombre like '%" + buscarUser.Text.Trim()+"%'" +
                    " or cedula like '%"+buscarUser.Text.Trim()+"%')");
                usersDGV.DataSource = ds.Tables[0];
            }
            
        }

        private void buscarUser_TextChanged(object sender, EventArgs e)
        {
            if (buscarUser.Text == "")
            {
                cargarTabla();
            }
        }

        private void MantenimientoUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
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

        private void editar_Click(object sender, EventArgs e)
        {
            if(usersDGV.SelectedRows.Count > 0)
            {
                int i = usersDGV.CurrentRow.Index;
                DataSet dsa = db.consultar("Select cedula, nombre, correo, edad, admin, imagen" +
                    " FROM personas WHERE cedula = " + usersDGV.Rows[i].Cells["cedula"].Value.ToString());


                NewUser nu = new NewUser();
                nu.cedUser.Text = dsa.Tables[0].Rows[0]["cedula"].ToString();
                nu.cedUser.Enabled = false;

                nu.nomUser.Text = dsa.Tables[0].Rows[0]["nombre"].ToString();
                nu.correoUser.Text = dsa.Tables[0].Rows[0]["correo"].ToString();
                nu.edadUser.Text = dsa.Tables[0].Rows[0]["edad"].ToString();
                nu.admUser.Checked = (dsa.Tables[0].Rows[0]["admin"].ToString() == "True") 
                    ? true : false;

                MemoryStream ms = new MemoryStream((byte[])dsa.Tables[0].Rows[0]["imagen"]);
                Image img = Image.FromStream(ms);
                nu.fotoUser.Image = img;

                if(nu.ShowDialog() != DialogResult.Abort)
                {
                    MessageBox.Show("Proceso exitoso!");
                    cargarTabla();
                }
                else
                {
                    MessageBox.Show("Operación no completada!");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una persona!");
            }
 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void eliminar_Click(object sender, EventArgs e)
        {

            string message = "Seguro? si elimina el registro no podrá recuperarlo";
            string title = "ATENCIÓN ⚠️⚠️";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int i = usersDGV.CurrentRow.Index;

                db.instruccionDB("Delete from personas WHERE cedula = " +
                        usersDGV.Rows[i].Cells["cedula"].Value.ToString());

                cargarTabla();
            }
            else
            {
                // Do something  
            }
            


            
        }

        private void crear_Click(object sender, EventArgs e)
        {

            NewUser nu = new NewUser();
            if (nu.ShowDialog() != DialogResult.Abort)
            {
                MessageBox.Show("Proceso exitoso!");
                cargarTabla();
                
            }
            else
            {
                MessageBox.Show("Operación no completada!");
            }
        }

        private void MantenimientoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarTabla()
        {
            DataSet ds = db.consultar("SELECT id, cedula, nombre, correo, edad, imagen from personas WHERE cedula != 0");
            usersDGV.DataSource = ds.Tables[0];
        }
    }
}
