using Datos;
using System.Data;
using Entidades;


namespace Individual.Visual
{
    

    public partial class MantenimientoUsuario : Form
    {

        private DataBase db = new DataBase();
        private int posX = 0, posY = 0;

        public MantenimientoUsuario()
        {
            InitializeComponent();
            CargarTabla();
            usersDGV.RowTemplate.Height = 55;
            usersDGV.RowHeadersVisible = false;
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
                    new Emergente("advertencia", "HECHO", "El proceso se ha completado exitosamente").ShowDialog();
                    CargarTabla();
                }
                else
                {
                    new Emergente("advertencia", "ERROR", "Operación no completada").ShowDialog();
                }
            }
            else
            {
                new Emergente("advertencia", "ERROR", "Debes seleccionar una persona").ShowDialog();
            }


        }


        private async void eliminar_Click(object sender, EventArgs e)
        {



            DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️⚠️", "Seguro ? si elimina el registro no podrá recuperarlo").ShowDialog();
            if (result == DialogResult.OK)
            {
                int i = usersDGV.CurrentRow.Index;

                await Task.Run(()=> db.instruccionDB("Delete from Personas WHERE Cedula = " +
                        usersDGV.Rows[i].Cells["Cedula"].Value.ToString()));

                CargarTabla();
            }

        }

        private void crear_Click(object sender, EventArgs e)
        {

            NewUser nu = new NewUser();
            if (nu.ShowDialog() != DialogResult.Abort)
            {
                new Emergente("advertencia", "HECHO", "El proceso se ha completado exitosamente").ShowDialog();
                CargarTabla();

            }
            else
            {
                new Emergente("advertencia", "ERROR", "Operación no completada").ShowDialog();
            }
        }


        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private async void CargarTabla()
        {
     
            btnRefrescar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCerrar.Enabled = false;

            await Task.Run(() => db.consultar("SELECT Id, Cedula, Nombre, Correo, Edad, Imagen from Personas WHERE Cedula != 0"));
            btnRefrescar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCerrar.Enabled = true;

            DataSet ds = db.Ds;
            List<Persona> listaPersonas = new List<Persona>();
            try
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Persona p = new Persona();
                    p.Id = (int)fila["Id"];
                    p.Cedula = ""+fila["Cedula"].ToString();
                    p.Nombre = "" + fila["Nombre"].ToString();
                    p.Correo = ""+fila["Correo"].ToString();
                    p.Edad = (int)fila["Edad"];
                    p.Foto = (byte[])fila["Imagen"];
                    listaPersonas.Add(p);
                }
                usersDGV.Rows.Clear();
                foreach (Persona persona in listaPersonas)
                {
                    usersDGV.Rows.Add(persona.Id, persona.Cedula, persona.Nombre, persona.Correo
                        , persona.Edad, persona.Foto);
                }
            }

            catch(Exception ex)
            {
                new Emergente("advertencia", "ERROR", "Ha ocurrido un error al cargar la base de datos\n " +
                    "Intenta nuevamente! "+ ex).ShowDialog();
            }

        }


    }
}
