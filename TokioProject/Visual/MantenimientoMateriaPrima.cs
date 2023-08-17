using Datos;
using Entidades;
using Individual.Visual;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GUIs.Visual
{
    public partial class MantenimientoMateriaPrima : Form
    {
        private DBMateriaPrima dbMateriaPrima;
        private DBCategoriaMateriaPrima dbCategorias;
        private DataBase dataBase;
        private DBProveedor dBProveedor;
        private DBRegistros dBRegistros;
        private Proveedor proveedorSeleccionado;
        private CategoriaMateriaPrima categoriaSeleccionada;
        private List<MateriaPrima> lista;

        public MantenimientoMateriaPrima()
        {
            InitializeComponent();
            dbMateriaPrima = new DBMateriaPrima();
            dBProveedor = new DBProveedor();
            dbCategorias = new DBCategoriaMateriaPrima();
            dBRegistros = new DBRegistros();
            dataBase = new DataBase();
            CargarProveedores();
            CargarCategorias();
            CargarTabla();
        }

        private void CargarTabla()
        {
            try
            {
                lista = dbMateriaPrima.CargarDatosMateriaPrima();

                materiaPrimaDGV.Rows.Clear();
                foreach (MateriaPrima materiaPrima in lista)
                {
                    materiaPrimaDGV.Rows.Add(
                        materiaPrima.Id,
                        materiaPrima.Categoria,
                        materiaPrima.Nombre,
                        materiaPrima.Color,
                        materiaPrima.Stock,
                        materiaPrima.Proveedor.Nombre,
                        (materiaPrima.Stock * materiaPrima.Precio),
                        materiaPrima.FechaCompra.ToShortDateString()
                    );
                }
                materiaPrimaDGV.Columns["precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                materiaPrimaDGV.Columns["precio"].DefaultCellStyle.Format = "N2";

                int id = (int)materiaPrimaDGV.Rows[0].Cells[0].Value;
                lblDescripcion.Text = lista.Find(m => m.Id == id).Descripcion;
                lblMedida.Text = lista.Find(m => m.Id == id).Stock + " " + ObtenerMedidaPorCategoria(lista.Find(m => m.Id == id).Categoria) + "(s)";
            }
            catch (Exception ex)
            {
                MostrarMensajeEmergente("ERROR DE EXCEPCIÓN", ex.Message);
            }
        }


        private void CargarProveedores()
        {
            var proveedores = dBProveedor.CargarDatosProveedores();

            var proveedorElegir = new Proveedor
            {
                Id = 0,
                Nombre = "TODOS", //Valor por defecto, elija un proveedor...
                Cedula_ruc = string.Empty,
                Correo = string.Empty,
                Telefono = string.Empty
            };

            proveedores.Insert(0, proveedorElegir);

            cbProveedor.DataSource = proveedores;
            cbProveedor.DisplayMember = "Nombre";
            cbProveedor.ValueMember = "Id";

            //Activar campo de busqueda
            cbProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CargarCategorias()
        {
            var categorias = dbCategorias.CargarDatosCategoriaMateriaPrima();

            var categoriaElegir = new CategoriaMateriaPrima
            {
                Id = 0,
                NombreCategoria = "TODOS" //Valor por defecto, elija una categoria...
            };
            categorias.Insert(0, categoriaElegir);

            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "nombreCategoria";
            cbCategoria.ValueMember = "id";

            cbProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }
        private void buscarMateriaPrima_TextChanged(object sender, EventArgs e)
        {
            //IDK
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                NewMateriaPrima crear = new NewMateriaPrima();
                crear.Owner = this.ParentForm;
                crear.ShowDialog();
                if (crear.Guardado)
                {
                    CargarTabla();
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeEmergente("ERROR DE EXCEPCION", ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (materiaPrimaDGV.SelectedRows.Count > 0)
                {
                    int selected = materiaPrimaDGV.CurrentRow.Index;
                    int id = (int)materiaPrimaDGV.Rows[selected].Cells[0].Value;

                    NewMateriaPrima editar = new NewMateriaPrima(id);

                    Proveedor proveedorInicial = (Proveedor)editar.cmbProveedor.SelectedItem;
                    Tuple<int, string> colorInicial = (Tuple<int, string>)editar.cmbColor.SelectedItem;

                    //Obtener los indices para seleccione el valor correcto del comboBox de proveedor y color
                    string nombreProveedor = (string)materiaPrimaDGV.Rows[selected].Cells[5].Value;
                    int indiceProveedor = editar.cmbProveedor.FindStringExact(nombreProveedor);
                    string nombreColor = (string)materiaPrimaDGV.Rows[selected].Cells[3].Value;
                    int indiceColor = editar.cmbColor.FindStringExact(nombreColor);
                    string nombreCategoria = (string)materiaPrimaDGV.Rows[selected].Cells[1].Value;
                    string nombreMateriaPrima = (string)materiaPrimaDGV.Rows[selected].Cells[2].Value;
                    int indiceCategoria = editar.cmbCategoria.FindStringExact(nombreCategoria);
                    string stockString = materiaPrimaDGV.Rows[selected].Cells[4].Value.ToString();
                    string precioString = materiaPrimaDGV.Rows[selected].Cells[6].Value.ToString();

                    //Asignar los valores a la ventana de editar
                    editar.txtDescripcion.Texts = lblDescripcion.Text;
                    editar.cmbColor.SelectedIndex = indiceColor;
                    editar.cmbCategoria.SelectedIndex = indiceCategoria;
                    editar.txtNombre.Texts = nombreMateriaPrima;
                    editar.txtStock.Texts = stockString;
                    editar.cmbProveedor.SelectedIndex = indiceProveedor;
                    editar.txtPrecio.Texts = (Double.Parse(precioString) / Int32.Parse(stockString)).ToString();
                    editar.fechaUltCompra.Value = DateTime.Parse(materiaPrimaDGV.Rows[selected].Cells[7].Value.ToString());
                    editar.Owner = this.ParentForm;
                    editar.ShowDialog();
                    if (editar.Guardado)
                    {
                        CargarTabla();
                    }
                }
                else
                {
                    MostrarMensajeEmergente("AVISO", "Debe seleccionar una commoditie");
                }
            }
            catch (Exception ex)
            {
                //MostrarMensajeEmergente("ERROR DE EXCEPCION", ex.Message);
                MessageBox.Show(ex + "");
            }
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            AlterarStock("agregar");
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            AlterarStock("restar");
        }
        private string ObtenerMedidaPorCategoria(string Categoria)
        {
            string medida = "";
            try
            {
                dataBase.consultar("SELECT medidaCategoria FROM CategoriaMateriaPrima WHERE nombreCategoria = '" + Categoria + "'");
                DataTable tabla = dataBase.Ds.Tables[0];
                medida = tabla.Rows[0]["medidaCategoria"].ToString();
            }
            catch (Exception ex)
            {
                MostrarMensajeEmergente("ERROR DE EXCEPCIÓN", ex.Message);
            }
            return medida;
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IDK
        }

        private void AlterarStock(string operacion)
        {
            try
            {
                if (cbCantidad.Value > 0)
                {
                    if (materiaPrimaDGV.SelectedRows.Count > 0)
                    {

                        int selected = materiaPrimaDGV.CurrentRow.Index;
                        int cantidad = (int)cbCantidad.Value;
                        int id = (int)materiaPrimaDGV.Rows[selected].Cells[0].Value;
                        int stockActual = (int)materiaPrimaDGV.Rows[selected].Cells[4].Value;
                        string nombre = (string)materiaPrimaDGV.Rows[selected].Cells[1].Value;
                        if (operacion == "restar" && stockActual < cantidad)
                        {
                            MostrarMensajeEmergente("AVISO", "Cantidad inválida, no hay suficiente stock!");
                        }
                        else
                        {
                            DialogResult confirmacion = new Emergente("si / no", "CONFIRMACIÓN",
                                                                        $"Desea {operacion} {cantidad} a {nombre}?"
                                                                        ).ShowDialog();
                            if (confirmacion == DialogResult.OK)
                            {
                                if (dbMateriaPrima.AlterarStock(operacion, id, cantidad))
                                {
                                    CrearRegistro(operacion, id, cantidad, "•Stock alterado");
                                    MostrarMensajeEmergente("EXITO", "Stock actualizado exitosamente");
                                    cbCantidad.Value = 0;
                                    CargarTabla();
                                }
                                else
                                {
                                    MostrarMensajeEmergente("ERROR", "Hubo un error al actualizar el estado");
                                }
                            }
                        }
                    }
                    else
                    {
                        MostrarMensajeEmergente("AVISO", "Debe seleccionar una commoditie");
                    }
                }
                else
                {
                    MostrarMensajeEmergente("AVISO", "Debe ingresar una cifra válida");
                }

            }
            catch (Exception ex)
            {
                MostrarMensajeEmergente("ERROR DE EXCEPCIÓN", ex.Message);
            }
        }
        private void CrearRegistro(string operacion, int id, int cantidad, string descripcion)
        {
            var owner = this.ParentForm as FrmPrincipal;

            var registro = new Registros();
            registro.Fecha = DateTime.Now;
            registro.Usuario = owner!.Sesion;
            registro.Descripcion = descripcion;
            registro.Cantidad = (operacion == "agregar") ? cantidad : -cantidad;
            dBRegistros.CrearRegistro(registro, "m" + id);
        }

        private void busquedaDGV(string entrada)
        {
            materiaPrimaDGV.ClearSelection();

            foreach (DataGridViewRow row in materiaPrimaDGV.Rows)
            {
                //Buscar descripcion desde variable de lista de materias primas guardada 

                string descripcion = lista.Find(x => x.Id == (int)row.Cells[0].Value).Descripcion.ToLower();
                string color = ((string)row.Cells[3].Value).ToLower();

                bool filtroProveedor = proveedorSeleccionado == null || proveedorSeleccionado.Nombre == row.Cells[5].Value.ToString() || proveedorSeleccionado.Nombre == "TODOS";
                bool filtroCategoria = categoriaSeleccionada == null || categoriaSeleccionada.NombreCategoria == row.Cells[1].Value.ToString() || categoriaSeleccionada.NombreCategoria == "TODOS";

                row.Visible = (descripcion.Contains(entrada) || color.Contains(entrada)) && filtroProveedor && filtroCategoria;
            }
        }

        private void MostrarMensajeEmergente(string titulo, string mensaje)
        {
            new Emergente("advertencia", titulo, mensaje).ShowDialog();
        }

        private void buscarMateriaPrima_TextChanged_1(object sender, EventArgs e)
        {
            busquedaDGV(buscarMateriaPrima.Text.ToLower());
        }

        private void cbProveedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            proveedorSeleccionado = cbProveedor.SelectedItem as Proveedor;
            busquedaDGV(buscarMateriaPrima.Text.ToLower());
        }

        private void materiaPrimaDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = materiaPrimaDGV.CurrentRow.Index;
            int id = (int)materiaPrimaDGV.Rows[selected].Cells[0].Value;
            MateriaPrima materiaPrima = lista.Find(m => m.Id == id);
            lblDescripcion.Text = materiaPrima.Descripcion;
            lblMedida.Text = lista.Find(m => m.Id == id).Stock + " " + ObtenerMedidaPorCategoria(lista.Find(m => m.Id == id).Categoria) + "(s)";
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoriaSeleccionada = cbCategoria.SelectedItem as CategoriaMateriaPrima;
            busquedaDGV(buscarMateriaPrima.Text.ToLower());
        }
    }
}