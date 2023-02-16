using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

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
                Console.WriteLine(e.ToString());
            }

            con.Close();
        }

    }
}
