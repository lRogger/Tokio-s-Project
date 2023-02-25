using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
            await Task.Run(() => db.consultar($"SELECT * FROM Productos WHERE IDproducto = '{id}'"));
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
