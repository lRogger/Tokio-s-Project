using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Modelos
{
    public class DataBase
    {
        private string server, user, pass, db, strCon;

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

            strCon = "server=" + server +
                ";user id=" + user + ";password=" + pass + ";database=" + db + ";";
        }

        public MySqlConnection conectarDB()
        {

            MySqlConnection con = new MySqlConnection();

            con.ConnectionString = strCon;
            con.Open();
            return con;
        }

        public DataSet consultar(string cmd)
        {

            DataSet ds = new DataSet();
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

            return ds;

        }

        public void instruccionDB(string cmd)
        {
            MySqlConnection con = conectarDB();
            MySqlCommand comando = new MySqlCommand(cmd, con);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
            con.Close();
        }

    }

}
