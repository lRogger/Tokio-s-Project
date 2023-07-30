using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Datos
{
    public class DBbalance
    {

        public List<Balances> LeerBalance()
        {
            DataBase db = new DataBase();
            db.consultar($"SELECT " +
                            $"Id, " +
                            $"CASE " +
                                $"WHEN SUBSTRING(PRODUCTO, 1, 1) = 'p' " +
                                $"THEN (SELECT nombre FROM productos WHERE idproducto = SUBSTRING(CAST(producto AS VARCHAR(10)), 2, LEN(producto))) " +
                                $"WHEN SUBSTRING(PRODUCTO, 1, 1) = 'm' " +
                                $"THEN (SELECT descripcion FROM MateriaPrima WHERE id = SUBSTRING(CAST(producto AS VARCHAR(10)), 2, LEN(producto))) " +
                                $" ELSE '-' " +
                            $"END AS producto, " +
                            $" Fecha, " +
                            $" Valor " +
                        $"FROM balance " +
                        $"ORDER BY Id DESC ");
            DataSet ds = db.Ds;
            var balance = new List<Balances>();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                Balances b = new Balances();
                b.Id = (int)fila["Id"];
                b.Producto = ""+fila["Producto"].ToString();
                b.Fecha = (DateTime)fila["Fecha"];
                b.Valor = (double)fila["Valor"];
                balance.Add(b);
            }
            return balance;
        }

        public void InsertarBalance(Balances b)
        {
            DataBase db = new DataBase();
            SqlConnection con = db.conectarDB();

            string query = $"INSERT INTO balance (producto, fecha, valor) VALUES (@Producto, @Fecha, @Valor);";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@Producto", b.Producto);
                command.Parameters.AddWithValue("@Fecha", b.Fecha);
                command.Parameters.AddWithValue("@Valor", b.Valor);
                command.ExecuteNonQuery();
            }
        }
    }

    
}
