using Entidades;
using System.Data;
using System.Data.SqlClient;

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
                        materiaPrima.Nombre = (string)reader[1];
                        materiaPrima.Color = (string)reader[2];
                        materiaPrima.Proveedor.Nombre = (string)reader[3];
                        materiaPrima.Stock = (int)reader[4];
                        materiaPrima.Precio = (double)reader[5];
                        materiaPrima.FechaCompra = (DateTime)reader[6];

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

        public bool InsertarMateriaPrima(MateriaPrima materiaPrima)
        {
            try
            {
                using (SqlConnection cn = dataBase.conectarDB())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarMateriaPrima", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@nombre", materiaPrima.Nombre);
                        cmd.Parameters.AddWithValue("@proveedorId", materiaPrima.Proveedor.Id);
                        cmd.Parameters.AddWithValue("@stock", materiaPrima.Stock);
                        cmd.Parameters.AddWithValue("@precio", materiaPrima.Precio);
                        cmd.Parameters.AddWithValue("@fecha", materiaPrima.FechaCompra);
                        cmd.Parameters.AddWithValue("@color", materiaPrima.Color);

                        SqlParameter registroExitosoParam = new SqlParameter("@Insert", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.Add(registroExitosoParam);

                        cmd.ExecuteNonQuery();

                        // Obtener el valor del parámetro de salida que indica si el registro fue exitoso o no
                        return (bool)registroExitosoParam.Value;
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
            throw new NotImplementedException();
        }
    }
}