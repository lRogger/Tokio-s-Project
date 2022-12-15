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
            string server = "localhost";
            string user = "root";
            string pass ="";
            string puerto = "3306";
            string db = "chichar";
            string strCon;


            DataSet ds = new DataSet();
            strCon = "server=" + server + ";port=" + puerto + 
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
                Console.WriteLine("Error: "+e);
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