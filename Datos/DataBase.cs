using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class DataBase
    {
        private string server, user, pass, db, strCon;
        private DataSet ds;

        /*  PRIMER HOST IMPLEMENTADO, DETALLES
         
            string server = "us-east.connect.psdb.cloud";
            string user = "u1deef4ok1sdaos254mh";
            string pass = "pscale_pw_eYFZVgEnWtWE0R6fAkZHVhXPL3vCw9wxeJ9fOaJ3SDd";
            string db = "chichar";
            string strCon;
        */

        public DataBase()
        {
            this.server = "db4free.net";
            this.user = "lrogger";
            this.pass = "Rogger123";
            this.db = "chichar";
            this.ds = new DataSet();
            strCon = "server=" + server +
                ";user id=" + user + ";password=" + pass + ";database=" + db + ";";
        }

        public DataSet Ds { get => ds; set => ds = value; }

        public MySqlConnection conectarDB()
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = strCon;
            con.Open();
            return con;
        }

        public void consultar(string cmd)
        {

            ds = new DataSet();

            try
            {

                MySqlConnection con = conectarDB();
                MySqlDataAdapter dp = new MySqlDataAdapter(cmd, con);
                dp.Fill(ds);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }

        }

        public void instruccionDB(string cmd)
        {
            MySqlConnection con = conectarDB();
            MySqlCommand comando = new MySqlCommand(cmd, con);

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
