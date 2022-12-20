using Individual.Modelos;
using System.Data;


namespace Individual.Visual
{
    public partial class MantenimientoUsuario : Form
    {

        int posY = 0, posX = 0;
        private DataBase db = new DataBase();


        public MantenimientoUsuario()
        {

            InitializeComponent();

            db.consultar("SELECT id, cedula, nombre, correo, edad, imagen from personas WHERE cedula != 0");
            DataSet ds = db.Ds;
            usersDGV.DataSource = ds.Tables[0];
            usersDGV.RowHeadersVisible = false;

            usersDGV.RowTemplate.Height = usersDGV.Columns[5].Width;

            DataGridViewImageColumn dgvImagen = (DataGridViewImageColumn)usersDGV.Columns[5];

            dgvImagen.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dgvImagen.DefaultCellStyle.NullValue = null;



        }



        private async void buscarUser_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                await Task.Run(() => db.consultar("SELECT id, cedula, nombre, " +
                    "correo, edad, imagen FROM personas WHERE cedula != 0 and (nombre like '%" + buscarUser.Text.Trim() + "%'" +
                    " or cedula like '%" + buscarUser.Text.Trim() + "%')"));
                DataSet ds = db.Ds;
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

        private async void editar_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                int i = usersDGV.CurrentRow.Index;
                await Task.Run(() => db.consultar("Select cedula, nombre, correo, edad, admin, imagen" +
                    " FROM personas WHERE cedula = " + usersDGV.Rows[i].Cells["cedula"].Value.ToString()));
                DataSet dsa = db.Ds;


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
            else
            {
                MessageBox.Show("Selecciona una persona!");
            }


        }


        private async void eliminar_Click(object sender, EventArgs e)
        {

            string message = "Seguro? si elimina el registro no podrá recuperarlo";
            string title = "ATENCIÓN ⚠️⚠️";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int i = usersDGV.CurrentRow.Index;

                await Task.Run(()=> db.instruccionDB("Delete from personas WHERE cedula = " +
                        usersDGV.Rows[i].Cells["cedula"].Value.ToString()));

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


        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cargarTabla()
        {
            btnRefrescar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            await Task.Run(() => db.consultar("SELECT id, cedula, nombre, correo, edad, imagen from personas WHERE cedula != 0"));
            btnRefrescar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            DataSet ds = db.Ds;
            try
            {

                usersDGV.DataSource = ds.Tables[0];
            }
            catch
            {
                new Emergente("advetencia", "ERROR", "Ha ocurrido un error al cargar la tabla, " +
                    "intenta nuevamente!");
            }

        }
    }
}
