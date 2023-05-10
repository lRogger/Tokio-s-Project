using Datos;
using System.Data;
using Entidades;
using GUIs.Properties;

namespace Individual.Visual
{
    

    public partial class MantenimientoUsuario : Form
    {

        private DataBase db = new DataBase();


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

        }

        private async void editar_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                int i = usersDGV.CurrentRow.Index;


                var personas = await new DBPersona().LeerPersona((string)usersDGV.Rows[i].Cells["Cedula"].Value);
                Persona p = personas[0];
                
                NewUser nu = new NewUser();
                nu.cedUser.Text = p.Cedula;
                nu.cedUser.Enabled = false;

                nu.nomUser.Text = p.Nombre;
                nu.correoUser.Text = p.Correo;
                nu.edadUser.Text = p.Edad.ToString();
                nu.admUser.Checked = p.Admin;
                nu.fotoUser.Image = (p.Foto != null) 
                    ? Image.FromStream(new MemoryStream(p.Foto)) 
                    : nu.fotoUser.Image = Resources.defaultAvatar;

                if (nu.ShowDialog() != DialogResult.Abort)
                {
                    new Emergente("advertencia", "HECHO", "El proceso se ha completado exitosamente").ShowDialog();
                    CargarTabla();
                }
                //else
                //{
                //    new Emergente("advertencia", "ERROR", "Operación no completada").ShowDialog();
                //}
            }
            else
            {
                new Emergente("advertencia", "ERROR", "Debes seleccionar una persona").ShowDialog();
            }


        }


        private void eliminar_Click(object sender, EventArgs e)
        {



            DialogResult result = new Emergente("si / no", "ATENCIÓN ⚠️⚠️", "Seguro ? si elimina el registro no podrá recuperarlo").ShowDialog();
            if (result == DialogResult.OK)
            {
                int i = usersDGV.CurrentRow.Index;

                string ced = (string)usersDGV.Rows[i].Cells["Cedula"].Value;
                new DBPersona().BorrarPersona(ced);

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
            //else
            //{
            //    new Emergente("advertencia", "ERROR", "Operación no completada").ShowDialog();
            //}
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
            try
            {
                btnRefrescar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCerrar.Enabled = false;

                List<Persona> listaPersonas = await new DBPersona().LeerPersona();

                btnRefrescar.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCerrar.Enabled = true;
          
                usersDGV.Rows.Clear();
                foreach (Persona persona in listaPersonas)
                {
                    if(persona.Cedula != "0")
                    {
                        if(persona.Foto == null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                Resources.defaultAvatar.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                persona.Foto = ms.ToArray();
                            }
                        }
                        usersDGV.Rows.Add(persona.Id, persona.Cedula, persona.Nombre, persona.Correo
                        , persona.Edad, persona.Foto);
                    }
                }
            }
            catch(Exception ex)
            {
                new Emergente("advertencia", "ERROR", "Ha ocurrido un error al cargar la base de datos\n " +
                     ex.Message).ShowDialog();
            }
        }
    }
}
