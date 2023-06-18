using Entidades;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Datos
{
    public class DBRegistros
    {
        public DBRegistros() { }


        public List<Registros> LeerRegistros()
        {
            var listaRegistros = new List<Registros>();
            try
            {
                DataBase db = new DataBase();
                SqlDataReader reader = db.SpConsulta("ObtenerRegistrosCompleto");

                while (reader.Read())
                {
                    Registros registro = new Registros();
                    registro.Id = reader.GetInt32(0);
                    registro.Fecha = reader.GetDateTime(1);

                    Persona usuario = new Persona();
                    usuario.Id = reader.GetInt32(2);
                    usuario.Cedula = reader.GetString(3);
                    usuario.Nombre = reader.GetString(4);
                    usuario.Correo = reader.GetString(5);
                    usuario.Edad = reader.GetDateTime(6);
                    usuario.Password = reader.GetString(7);
                    usuario.Admin = reader.GetBoolean(8);
                    usuario.Foto = reader.GetString(9);
                    registro.Usuario = usuario;

                    Prenda producto = new Prenda();
                    if (!reader.IsDBNull(10))
                        producto.Id = (int)reader.GetInt32(10);
                    producto.Categoria = reader.IsDBNull(11) ? null : reader.GetString(11);
                    producto.Talla = reader.IsDBNull(12) ? null : reader.GetString(12);
                    producto.Nombre = reader.IsDBNull(13) ? null : reader.GetString(13);
                    producto.Descripcion = reader.IsDBNull(14) ? null : reader.GetString(14);
                    producto.Color = reader.IsDBNull(15) ? null : reader.GetString(15);
                    if (!reader.IsDBNull(16))
                        producto.Stock = (int)reader.GetInt32(16);
                    if (!reader.IsDBNull(17))
                        producto.Precio = (double)reader.GetDouble(17);
                    if (!reader.IsDBNull(18))
                        producto.Activo = (bool)reader.GetBoolean(18);
                    registro.Producto = producto;

                    MateriaPrima materiaPrima = new MateriaPrima();
                    if (!reader.IsDBNull(19))
                        materiaPrima.Id = (int)reader.GetInt32(19);
                    materiaPrima.Nombre = reader.IsDBNull(20) ? null : reader.GetString(20);
                    if (!reader.IsDBNull(21))
                    {
                        int proveedorId = reader.GetInt32(21);
                        materiaPrima.Proveedor = new Proveedor { Id = proveedorId };
                    }
                    if (!reader.IsDBNull(22))
                        materiaPrima.Stock = (int)reader.GetInt32(22);
                    if (!reader.IsDBNull(23))
                        materiaPrima.Precio = (double)reader.GetDouble(23);
                    if (!reader.IsDBNull(24))
                        materiaPrima.FechaCompra = (DateTime)reader.GetDateTime(24);
                    materiaPrima.Color = reader.IsDBNull(25) ? null : reader.GetString(25);
                    registro.MateriaPrima = materiaPrima;

                    registro.Descripcion = reader.IsDBNull(26) ? null : reader.GetString(26);
                    if (!reader.IsDBNull(27))
                        registro.Cantidad = (int)reader.GetInt32(27);

                    listaRegistros.Add(registro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listaRegistros;
        }


        public void CrearRegistro(Registros registro, string IdProduct)
        {
            string query = $"INSERT INTO Registros (Fecha, IdUsuario, Descripcion, " +
                $"Cantidad, IdProducto) VALUES ('{registro.Fecha.ToString("yyyy-MM-dd")}',{registro.Usuario.Id}," +
                $"'{registro.Descripcion}',{registro.Cantidad},'{IdProduct}')";
            new DataBase().instruccionDB(query);
        }
    }
}
