using MySql.Data.MySqlClient;
using System.Data;
using System.IO.Enumeration;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

namespace LibreriaGrupal
{

    public class Utilidades
    {

          

        public static MySqlConnection conectarDB()
        {
            /*
            string server = "us-east.connect.psdb.cloud";
            string user = "u1deef4ok1sdaos254mh";
            string pass = "pscale_pw_eYFZVgEnWtWE0R6fAkZHVhXPL3vCw9wxeJ9fOaJ3SDd";
            string db = "chichar";
            string strCon;
            */

            string server = "db4free.net";
            string user = "lrogger";
            string pass = "Rogger123";
            string db = "chichar";
            string strCon;

            MySqlConnection con = new MySqlConnection();
            strCon = "server=" + server +
                ";user id=" + user + ";password=" + pass + ";database=" + db + ";";
            con.ConnectionString = strCon;
            con.Open();
            return con;
        }

        public static DataSet consultar (string cmd)
        {
            
            DataSet ds = new DataSet();
            try
            {

                MySqlConnection con = conectarDB();
                MySqlDataAdapter dp = new MySqlDataAdapter(cmd, con);
                dp.Fill(ds);
                con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:"+e);
            }

            return ds;
            
        }

        public static void instruccionDB(string cmd)
        {
            MySqlConnection con = conectarDB();
            MySqlCommand comando = new MySqlCommand(cmd, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        

        public bool validar(char e, string tipo)
        {
            switch (tipo)
            {
                case "numero":
                    if (!char.IsNumber(e) && !char.IsControl(e))
                    {
                        return true;
                    }
                    break;

                case "letras":
                    if(!char.IsLetter(e) && !char.IsControl(e))
                    {
                        return true;
                    }
                    break;
                    
            }
            return false;
        }

    }


}//Lindsay estuvo aqui