using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Datos
{
    public class DBMateriaPrima
    {
        DataBase dataBase = new DataBase();

        public List<MateriaPrima> CargarDatosMateriaPrima()
        {
            try
            {
                List<MateriaPrima> lista = new List<MateriaPrima>();

                using (SqlDataReader reader = dataBase.SpConsulta("ObtenerMateriaPrima"))
                {
                    while (reader.Read())
                    {
                        MateriaPrima materiaPrima = new MateriaPrima();
                        materiaPrima.Id = (int)reader[0];
                        materiaPrima.Categoria = (string)reader[1];
                        materiaPrima.Nombre = (string)reader[2];
                        materiaPrima.Descripcion = (string)reader[3];
                        materiaPrima.Color = (string)reader[4];
                        materiaPrima.Proveedor.Nombre = (string)reader[5];
                        materiaPrima.Stock = (int)reader[6];
                        materiaPrima.Precio = (double)reader[7];
                        materiaPrima.FechaCompra = (DateTime)reader[8];

                        lista.Add(materiaPrima);
                    }
                }

                return lista;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public MateriaPrima ObtenerMateriaPrimaPorId(int id)
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            try
            {
                using (SqlConnection cn = dataBase.conectarDB())
                {
                    using (SqlCommand cmd = new SqlCommand($"SELECT M.id,(SELECT nombreCategoria FROM CategoriaMateriaPrima WHERE id = M.categoriaId) [nombreCategoria]," +
                                                           $"M.nombre, M.descripcion, M.proveedorId, M.stock, M.precio, M.fechaCompra," +
                                                           $"(SELECT Color FROM Colores WHERE IdColor = M.colorId) [Color]" +
                                                           $"FROM MateriaPrima M WHERE Id = @id", cn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                materiaPrima.Id = (int)reader["id"];
                                materiaPrima.Categoria = (string)reader["nombreCategoria"];
                                materiaPrima.Nombre = (string)reader["nombre"];
                                materiaPrima.Descripcion = (string)reader["descripcion"];
                                materiaPrima.Proveedor.Id = (int)reader["proveedorId"];
                                materiaPrima.Stock = (int)reader["stock"];
                                materiaPrima.Precio = (double)reader["precio"];
                                materiaPrima.FechaCompra = (DateTime)reader["fechaCompra"];
                                materiaPrima.Color = (string)reader["Color"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return materiaPrima;
        }
        public int InsertarMateriaPrima(MateriaPrima materiaPrima)
        {
            try
            {
                using (SqlConnection cn = dataBase.conectarDB())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarMateriaPrima", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@categoria", materiaPrima.Categoria);
                        cmd.Parameters.AddWithValue("@descripcion", materiaPrima.Descripcion);
                        cmd.Parameters.AddWithValue("@nombre", materiaPrima.Nombre);
                        cmd.Parameters.AddWithValue("@proveedorId", materiaPrima.Proveedor.Id);
                        cmd.Parameters.AddWithValue("@stock", materiaPrima.Stock);
                        cmd.Parameters.AddWithValue("@precio", materiaPrima.Precio);
                        cmd.Parameters.AddWithValue("@fecha", materiaPrima.FechaCompra);
                        cmd.Parameters.AddWithValue("@color", materiaPrima.Color);

                        SqlParameter registroExitosoParam = new SqlParameter("@Insert", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.Add(registroExitosoParam);

                        cmd.ExecuteNonQuery();

                        // Obtener el id del producto insertado
                        return (int)registroExitosoParam.Value;
                        Debug.WriteLine(registroExitosoParam.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EditarMateriaPrima(MateriaPrima materiaPrima)
        {
            try
            {
                using (SqlConnection cn = dataBase.conectarDB())
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarMateriaPrima", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", materiaPrima.Id);
                        cmd.Parameters.AddWithValue("@descripcion", materiaPrima.Descripcion);
                        cmd.Parameters.AddWithValue("@proveedorId", materiaPrima.Proveedor.Id);
                        cmd.Parameters.AddWithValue("@stock", materiaPrima.Stock);
                        cmd.Parameters.AddWithValue("@precio", materiaPrima.Precio);
                        cmd.Parameters.AddWithValue("@fecha", materiaPrima.FechaCompra);
                        cmd.Parameters.AddWithValue("@color", materiaPrima.Color);

                        SqlParameter actualizadoExitosoParam = new SqlParameter("@Actualizado", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.Add(actualizadoExitosoParam);

                        cmd.ExecuteNonQuery();

                        // Obtener el valor del parámetro de salida que indica si la actualiación fue exitoso o no
                        return (bool)actualizadoExitosoParam.Value;
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AlterarStock(string operacion, int id, int cantidad)
        {
            try
            {
                using (SqlConnection cn = dataBase.conectarDB())
                {
                    using (SqlCommand cmd = new SqlCommand("AlterarStockMateriaPrima", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@operacion", operacion);

                        SqlParameter actualizadoExitosoParam = new SqlParameter("@Actualizado", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.Add(actualizadoExitosoParam);

                        cmd.ExecuteNonQuery();

                        // Obtener el valor del parámetro de salida que indica si la actualiación fue exitoso o no
                        return (bool)actualizadoExitosoParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}