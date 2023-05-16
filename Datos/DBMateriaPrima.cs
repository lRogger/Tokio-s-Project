using Entidades;
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