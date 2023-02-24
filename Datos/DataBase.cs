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

            //SE CAMBIÓ MYSQL POR SQL SERVER
            this.server = "serverogger.database.windows.net";
            this.user = "lRogger";
            this.pass = "Rogger123";
            
            this.db = "poe";
            this.strCon = $"server={server}; user id={user}; password={pass}; database={db};";

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
                Console.WriteLine("Error:" + e.Message);
                
            }

        }

        public async void instruccionDB(string cmd)
        {
            SqlConnection con = conectarDB();
            SqlCommand comando = new SqlCommand(cmd, con);

            try
            {
                await comando.ExecuteNonQueryAsync();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            con.Close();
        }

        public async void SpDB(string sp, List<SqlParameter> parametros)
        {

            SqlConnection con = conectarDB();

            SqlCommand comando = new SqlCommand(sp, con);
            comando.CommandType = CommandType.StoredProcedure;

            foreach(SqlParameter p in parametros)
            {
                comando.Parameters.Add(p);
            }
            await comando.ExecuteNonQueryAsync();
            con.Close();
        }

        public async Task<SqlDataReader> SpConsulta(string sp)
        {
            SqlConnection con = conectarDB();

            SqlCommand comando = new SqlCommand(sp, con);
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = await comando.ExecuteReaderAsync();

            return reader;

        }


    }
}
