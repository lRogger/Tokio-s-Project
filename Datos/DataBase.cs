using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class DataBase
    {
        private string server, user, pass, db, strCon;
        private DataSet ds;

        

        public DataBase()
        {

            /* HOST GRATUITO, ALGO LENTO, MANTENIMIENTO
             * 
                this.server = "db4free.net";
                this.user = "lrogger";
                this.pass = "Tokio123";
                this.db = "chichar";
                
            */

            /*  PRIMER HOST IMPLEMENTADO, PROBLEMA PARA SUBIR IMAGENES EN DB,
             *  GENERALMENTE SE UTILIZA UNA NUBE APARTE PERO PARA EFECTOS DE PRÁCTICA
             *  DECIDIMOS ALMACENARLO EN UNA BD

                this.server = "us-east.connect.psdb.cloud";
                this.user = "u1deef4ok1sdaos254mh";
                this.pass = "pscale_pw_eYFZVgEnWtWE0R6fAkZHVhXPL3vCw9wxeJ9fOaJ3SDd";
                this.db = "chichar";
             */

            //  HOST LOCAL
            this.server = "localhost";
            this.user = "root";
            this.pass = "";
            this.db = "chichar";
             
            this.ds = new DataSet();
            this.strCon = "server=" + server +
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

            Ds = new DataSet();

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
