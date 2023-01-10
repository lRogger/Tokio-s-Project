using MySql.Data.MySqlClient;
using System.Data;
using System.IO.Enumeration;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

namespace LibreriaGrupal
{

    public class Utilidades
    {



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
                    if(!char.IsLetter(e) && !char.IsControl(e) && (!char.IsSeparator(e)))
                    {
                        return true;
                    }
                    break;

                case "decimal":
                    if (!char.IsControl(e) && !char.IsDigit(e) && (e != ','))
                    {
                        return true;
                    }
                    break;

            }
            return false;
        }

    }


}//Lindsay estuvo aqui