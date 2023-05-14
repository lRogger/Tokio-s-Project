using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class DBMateriaPrima
    {
        DataBase dataBase = new DataBase();

        public async Task<List<MateriaPrima>> CargarDatosMateriaPrima()
        {
            try
            {
                List<MateriaPrima> lista = new List<MateriaPrima>();
                MateriaPrima materiaPrima = new MateriaPrima();

                using (SqlDataReader reader = await dataBase.SpConsulta("ObtenerDatosMateriaPrima"))
                {
                    while (reader.Read())
                    {
                        materiaPrima.Id = (int)reader[0];
                        materiaPrima.Nombre = (string)reader[1];
                        materiaPrima.Proveedor.Cedula_ruc = (string)reader[2];
                        materiaPrima.Stock = (int)reader[3];
                        materiaPrima.Precio = (double)reader[4];
                        materiaPrima.FechaCompra = (DateTime)reader[5];

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
    }
}