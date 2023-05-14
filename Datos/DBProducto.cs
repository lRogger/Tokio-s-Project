using Entidades;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;


namespace Datos
{
    public class DBProducto
    {

        public void InhabilitarProducto(int id)
        {
            DataBase db = new DataBase();
            db.instruccionDB($"UPDATE Productos SET Activo = 0 WHERE IDproducto = {id}");
        }

        public void HabilitarProducto(int id)
        {
            DataBase db = new DataBase();
            db.instruccionDB($"UPDATE Productos SET Activo = 1 WHERE IDproducto = {id}");
        }

        
        public async Task<List<Prenda>> LeerProducto(int id)
        {
            DataBase db = new DataBase();
            await Task.Run(() => db.consultar($"SELECT IDproducto," +
                                                $"CAST(C.IdCategoria AS VARCHAR) + '-' + C.Categoria AS Categoria," +
                                                $"CAST(T.IdTalla AS VARCHAR) + '-' + T.Talla AS Talla," +
                                                $"Nombre," +
                                                $"Descripcion," +
                                                $"CAST(CL.IdColor AS VARCHAR) + '-' + CL.Color AS Color," +
                                                $"Stock," +
                                                $"Precio," +
                                                $"Activo " +
                                               $"FROM Productos P " +
                                               $"INNER JOIN Talla T ON P.Talla = T.IdTalla " +
                                               $"INNER JOIN CategoriaProducto C ON P.Categoria = C.IdCategoria " +
                                               $"INNER JOIN Colores CL ON P.Color = CL.IdColor " +
                                               $"WHERE IDproducto = {id};"));
            DataSet ds = db.Ds;
            var prendas = new List<Prenda>();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {

                Prenda p = new Prenda();

                p.Id = (int)fila["IDproducto"];
                p.Categoria = "" + fila["Categoria"].ToString();
                p.Talla = "" + fila["Talla"].ToString();
                p.Nombre = "" + fila["Nombre"].ToString();
                p.Descripcion = (string)fila["Descripcion"];
                p.Color = (string)fila["Color"];
                p.Stock = (int)fila["Stock"];
                p.Precio = (double)fila["Precio"];
                p.Activo = (bool)fila["Activo"];

                prendas.Add(p);
            }
            return prendas;
        }
        

        public async Task<List<Prenda>> LeerProductos()
        {
            DataBase db = new DataBase();
            SqlDataReader reader = await db.SpConsulta("ObtenerProductos");
            var listaProductos = new List<Prenda>();

            while (reader.Read())
            {
                Prenda p = new Prenda();
                p.Id = reader.GetInt32(0);
                p.Categoria = reader.GetString(1);
                p.Talla = reader.GetString(2);
                p.Nombre = reader.GetString(3);
                p.Descripcion = reader.GetString(4);
                p.Color = reader.GetString(5);
                p.Stock = reader.GetInt32(6);
                p.Precio = reader.GetDouble(7);
                p.Activo = reader.GetBoolean(8);

                listaProductos.Add(p);
            }

            return listaProductos;
        }

        /* DESCONTINUADO -
        public async Task<List<Prenda>> LeerProducto()
        {
            DataBase db = new DataBase();
            await Task.Run(() => db.consultar($"SELECT * FROM Productos"));
            DataSet ds = db.Ds;
            var prendas = new List<Prenda>();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {

                Prenda p = new Prenda();

                p.Id = (int)fila["IDproducto"];
                p.Categoria = "" + fila["Categoria"].ToString();
                p.Talla = "" + fila["Talla"].ToString();
                p.Nombre = "" + fila["Nombre"].ToString();
                p.Descripcion = (string)fila["Descripcion"];
                p.Color = (string)fila["Color"];
                p.Stock = (int)fila["Stock"];
                p.Precio = (double)fila["Precio"];
                p.Activo = (bool)fila["Activo"];

                prendas.Add(p);
            }
            return prendas;
        }
        */

        public async Task<int> CrearProducto(Prenda p)
        {
            //Esto se usa por problemas con double en sql
            string doubleArreglado = p.Precio.ToString("0.00", CultureInfo.InvariantCulture);

            DataBase db = new DataBase();
            int idProducto;
            using (SqlConnection con = db.conectarDB())
            {
                using (SqlCommand command = new SqlCommand("InsertarProducto", con))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nombre", p.Nombre);
                    command.Parameters.AddWithValue("@Categoria", p.Categoria);
                    command.Parameters.AddWithValue("@Talla", p.Talla);
                    command.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                    command.Parameters.AddWithValue("@Color", p.Color);
                    command.Parameters.AddWithValue("@Stock", p.Stock);
                    command.Parameters.AddWithValue("@Precio", doubleArreglado);

                    SqlParameter outputIdParam = new SqlParameter("@IdProducto", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);
                    await command.ExecuteNonQueryAsync();

                    idProducto = Convert.ToInt32(outputIdParam.Value);
                }
            }
            return idProducto;
        }

        public void EditarProducto(Prenda p, int id)
        {
            //Esto se usa por problemas con double en sql
            string doubleArreglado = p.Precio.ToString("0.00", CultureInfo.InvariantCulture);

            int activo = (p.Activo) ? 1 : 0;
            new DataBase().instruccionDB($"UPDATE Productos SET " +
                    $"Nombre='{p.Nombre}',Categoria='{p.Categoria}',Talla='{p.Talla}'," +
                    $"Descripcion='{p.Descripcion}',Color='{p.Color}'," +
                    $"Stock={p.Stock},Precio={doubleArreglado}, Activo={activo} WHERE IDproducto = '{id}'");
        }

        public void ActualizarStock(int stock, int id)
        {
            new DataBase().instruccionDB($"UPDATE Productos SET Stock={stock} WHERE IDproducto = {id}");
        }

    }
}
