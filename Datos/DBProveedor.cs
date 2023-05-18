using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DBProveedor
    {
        DataBase dataBase = new DataBase();
        public bool InsertarProveedor(Proveedor proveedor)
        {
            try
            {
                using (SqlConnection cn = dataBase.conectarDB())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarProveedor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@nombre",proveedor.Nombre);
                        cmd.Parameters.AddWithValue("@identificacion", proveedor.Cedula_ruc);
                        cmd.Parameters.AddWithValue("@correo", proveedor.Correo);
                        cmd.Parameters.AddWithValue("@telefono", proveedor.Telefono);

                        SqlParameter registroExitosoParam = new SqlParameter("@Insert", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.Add(registroExitosoParam);

                        cmd.ExecuteNonQuery();

                        // Obtener el valor del parámetro de salida que indica si el registro fue exitoso o no
                        return (bool)registroExitosoParam.Value;
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Proveedor> CargarDatosProveedores()
        {
            try
            {
                List<Proveedor> lista = new List<Proveedor>();

                using (SqlDataReader reader = dataBase.SpConsulta("ObtenerProveedores"))
                {
                    while (reader.Read())
                    {
                        Proveedor proveedor = new Proveedor();
                        proveedor.Id = (int)reader[0];
                        proveedor.Nombre = (string)reader[1];
                        proveedor.Cedula_ruc = (string)reader[2];
                        proveedor.Correo = (string)reader[3];
                        proveedor.Telefono = (string)reader[4];
                        proveedor.Activo = (bool)reader[5];

                        lista.Add(proveedor);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EditarProveedor(Proveedor proveedor)
        {
            try
            {
                using (SqlConnection cn = dataBase.conectarDB())
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarProveedor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                        cmd.Parameters.AddWithValue("@identificacion", proveedor.Cedula_ruc);
                        cmd.Parameters.AddWithValue("@correo", proveedor.Correo);
                        cmd.Parameters.AddWithValue("@telefono", proveedor.Telefono);

                        SqlParameter actualizadoExitosoParam = new SqlParameter("@Actualizado", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.Add(actualizadoExitosoParam);

                        cmd.ExecuteNonQuery();

                        return (bool)actualizadoExitosoParam.Value;
                    }
                }

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DesactivarActivarProveedor(string id, int valor)
        {
            dataBase.instruccionDB($"UPDATE Proveedor SET activo = {valor} WHERE cedula_ruc = '{id}'");
        }
    }
}