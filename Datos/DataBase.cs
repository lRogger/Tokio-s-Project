using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DataBase
    {
        private string strCon;
        private DataSet ds;


        public DataBase()
        {
            this.strCon = ConfigurationManager.ConnectionStrings["conexionsql"].ConnectionString;

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
            try
            {
                using (SqlConnection con = conectarDB())
                {
                    SqlDataAdapter dp = new SqlDataAdapter(cmd, con);
                    dp.Fill(ds);
                }    
            }
            catch (Exception e)
            {
                throw new Exception("Error:" + e.Message);            
            }
        }

        public async void instruccionDB(string cmd)
        {
            try
            {
                using (SqlConnection con = conectarDB())
                {
                    SqlCommand comando = new SqlCommand(cmd, con);
                    await comando.ExecuteNonQueryAsync();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async void storeProcedureDB(string sp, List<SqlParameter> parametros)
        {
            try
            {
                using (SqlConnection con = conectarDB())
                {
                    SqlCommand comando = new SqlCommand(sp, con);
                    comando.CommandType = CommandType.StoredProcedure;
                    if(parametros != null && parametros.Count > 0)
                    {
                        comando.Parameters.AddRange(parametros.ToArray());
                    }
                    await comando.ExecuteNonQueryAsync();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<SqlDataReader> storeProcedureConsulta(string sp)
        {
            try
            {
                SqlConnection con = conectarDB();
                using (SqlCommand comando = new SqlCommand(sp, con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = await comando.ExecuteReaderAsync();
                    return reader;
                }                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}