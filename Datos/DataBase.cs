using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Datos
{
    public class DataBase
    {
        private string server, user, pass, db, strCon;
        private DataSet ds;


        public DataBase()
        {
            
            //SE CAMBIO EL SERVIDOR DE LA BASE DE DATOS
            this.server = "tokio-server.database.windows.net";
            this.user = "tokio";
            this.pass = "semestre6!";
            this.db = "TOKIO-PROYECTO";

            this.strCon = $"Data Source={server};Initial Catalog={db};Persist Security Info=True;User ID={user};Password={pass};";

            this.ds = new DataSet();
        }

        public DataSet Ds { get => ds; set => ds = value; }

        public SqlConnection conectarDB()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            con.Open();
            return con;
        }

        public void consultar(string cmd)
        {

            Ds = new DataSet();

            try
            {
                SqlConnection con = conectarDB();
                SqlDataAdapter dp = new SqlDataAdapter(cmd, con);
                dp.Fill(ds);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                
            }

        }

        public void instruccionDB(string cmd)
        {
            SqlConnection con = conectarDB();
            SqlCommand comando = new SqlCommand(cmd, con);

            try
            {
                comando.ExecuteNonQuery();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            con.Close();
        }

        public void SpDB(string sp, List<SqlParameter> parametros)
        {

            SqlConnection con = conectarDB();

            SqlCommand comando = new SqlCommand(sp, con);
            comando.CommandType = CommandType.StoredProcedure;

            foreach(SqlParameter p in parametros)
            {
                comando.Parameters.Add(p);
            }
            comando.ExecuteNonQuery();
            con.Close();
        }

        public SqlDataReader SpConsulta(string sp)
        {
            SqlConnection con = conectarDB();

            SqlCommand comando = new SqlCommand(sp, con);
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = comando.ExecuteReader();

            return reader;

        }


    }
}
