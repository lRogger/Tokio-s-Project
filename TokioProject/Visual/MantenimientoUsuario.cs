using Datos;
using System.Data;



namespace Individual.Visual
{
    public partial class MantenimientoUsuario : Form
    {

        private DataBase db = new DataBase();


        public MantenimientoUsuario()
        {
            InitializeComponent();
            cargarTabla();
            usersDGV.RowTemplate.Height = 55;
            
        }


        private void buscarUser_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void buscarUser_TextChanged(object sender, EventArgs e)
        {

            if (buscarUser.Text.Trim() != "")
            {
                usersDGV.CurrentCell = null;
                foreach (DataGridViewRow row in usersDGV.Rows)
                {
                    bool encontrado = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null &&
                            (cell.Value.ToString()+"").ToLower().Contains(buscarUser.Text.ToLower()))
                        {
                            encontrado = true;
                            break;
                        }
                    }

                    if (encontrado)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        
                        row.Visible = false;
                    }
                }
            }
            else
            {
                foreach(DataGridViewRow row in usersDGV.Rows)
                {
                    if(!row.Visible)
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        private void MantenimientoUsuario_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private async void editar_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                int i = usersDGV.CurrentRow.Index;
                await Task.Run(() => db.consultar("Select Cedula, Nombre, Correo, Edad, Admin, Imagen" +
                    " FROM Personas WHERE Cedula = " + usersDGV.Rows[i].Cells["Cedula"].Value.ToString()));
                DataSet dsa = db.Ds;


                NewUser nu = new NewUser();
                nu.cedUser.Text = dsa.Tables[0].Rows[0]["Cedula"].ToString();
                nu.cedUser.Enabled = false;

                nu.nomUser.Text = dsa.Tables[0].Rows[0]["Nombre"].ToString();
                nu.correoUser.Text = dsa.Tables[0].Rows[0]["Correo"].ToString();
                nu.edadUser.Text = dsa.Tables[0].Rows[0]["Edad"].ToString();
                nu.admUser.Checked = (dsa.Tables[0].Rows[0]["Admin"].ToString() == "True")
                    ? true : false;

                MemoryStream ms = new MemoryStream((byte[])dsa.Tables[0].Rows[0]["Imagen"]);
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

                await Task.Run(()=> db.instruccionDB("Delete from Personas WHERE Cedula = " +
                        usersDGV.Rows[i].Cells["Cedula"].Value.ToString()));

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

        private void MantenimientoUsuario_Load(object sender, EventArgs e)
        {
          
        }

        private async void cargarTabla()
        {
            btnRefrescar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            await Task.Run(() => db.consultar("SELECT Id, Cedula, Nombre, Correo, Edad, Imagen from Personas WHERE cedula != 0"));
            btnRefrescar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            DataSet ds = db.Ds;
            try
            {
                usersDGV.DataSource = ds.Tables[0];
                usersDGV.RowHeadersVisible = false;
                DataGridViewImageColumn dgvImagen = (DataGridViewImageColumn)usersDGV.Columns[5];
                dgvImagen.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dgvImagen.DefaultCellStyle.NullValue = null;
                usersDGV.Columns["Id"].Width = 50;
                usersDGV.Columns["Nombre"].Width = 105;
                usersDGV.Columns["Cedula"].Width = 80;
                usersDGV.Columns["Correo"].Width = 180;
                usersDGV.Columns["Edad"].Width = 50;
                usersDGV.Columns["Imagen"].Width = 55;
                usersDGV.ReadOnly = true;

            }
            catch
            {
                new Emergente("advetencia", "ERROR", "Ha ocurrido un error al cargar la tabla, " +
                    "intenta nuevamente!");
            }
            

        }
    }
}
