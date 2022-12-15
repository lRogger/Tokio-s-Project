using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;


namespace LibreriaGrupal
{
    public class Utilidades
    {

        public static DataSet consultar (string cmd)
        {
            string server = "us-east.connect.psdb.cloud";
            string user = "u1deef4ok1sdaos254mh";
            string pass = "pscale_pw_eYFZVgEnWtWE0R6fAkZHVhXPL3vCw9wxeJ9fOaJ3SDd";
            string db = "chichar";
            string strCon;


            DataSet ds = new DataSet();
            strCon = "server=" + server +  
                ";user id=" + user + ";password=" + pass + ";database=" + db + ";";
            MySqlConnection con = new MySqlConnection(strCon);
            try
            {

                
                con.ConnectionString = strCon;
                con.Open();

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