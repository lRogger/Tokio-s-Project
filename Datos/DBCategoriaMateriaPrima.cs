using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Datos
{
    public class DBCategoriaMateriaPrima
    {
        DataBase dataBase = new DataBase();

        public List<CategoriaMateriaPrima> CargarDatosCategoriaMateriaPrima()
        {
            try
            {
                List<CategoriaMateriaPrima> lista = new List<CategoriaMateriaPrima>();

                using (SqlDataReader reader = dataBase.SpConsulta("ObtenerCategoriasMateriaPrima"))
                {
                    while (reader.Read())
                    {
                        CategoriaMateriaPrima categoria = new CategoriaMateriaPrima();
                        categoria.Id = (int)reader[0];
                        categoria.NombreCategoria = (string)reader[1];
                        Debug.WriteLine(categoria.NombreCategoria);
                        Debug.WriteLine(categoria.Id);

                        lista.Add(categoria);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
