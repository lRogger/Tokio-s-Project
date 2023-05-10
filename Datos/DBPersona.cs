﻿using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DBPersona
    {

        public void BorrarPersona(string ced)
        {
            DataBase db = new DataBase();
            db.instruccionDB($"Delete from Personas WHERE Cedula = '{ced}'");
        }

        public async Task<List<Persona>> LeerPersona(string ced)
        {
            DataBase db = new DataBase();
            await Task.Run(() => db.consultar($"SELECT * FROM Personas WHERE Cedula = '{ced}'"));
            DataSet ds = db.Ds;
            var personas = new List<Persona>();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                Persona p = new Persona();
                p.Id = (int)fila["Id"];
                p.Cedula = "" + fila["Cedula"].ToString();
                p.Nombre = "" + fila["Nombre"].ToString();
                p.Correo = "" + fila["Correo"].ToString();
                p.Edad = (int)fila["Edad"];
                p.Foto = (fila["Imagen"] != DBNull.Value) ? (byte[])fila["Imagen"] : null;
                p.Password = (string)fila["Password"];
                p.Admin = (bool)fila["Admin"];
                personas.Add(p);
            }
            return personas;
        }

        public async Task<List<Persona>> LeerPersona()
        {
            DataBase db = new DataBase();
            await Task.Run(() => db.consultar($"SELECT * FROM Personas"));
            DataSet ds = db.Ds;
            var personas = new List<Persona>();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                Persona p = new Persona();
                p.Id = (int)fila["Id"];
                p.Cedula = (string)fila["Cedula"];
                p.Nombre = (string)fila["Nombre"];
                p.Correo = (string)fila["Correo"];
                p.Edad = (int)fila["Edad"];
                p.Foto = (fila["Imagen"] != DBNull.Value) ? (byte[])fila["Imagen"] : null;
                p.Password = (string)fila["Password"];
                p.Admin = (bool)fila["Admin"];
                personas.Add(p);
            }
            return personas;
        }

        public void ActualizaUsuario(Persona p)
        {
            DataBase db = new DataBase();
            var parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@cedula", p.Cedula));
            parametros.Add(new SqlParameter("@nombre", p.Nombre));
            parametros.Add(new SqlParameter("@correo", p.Correo.ToLower()));
            parametros.Add(new SqlParameter("@edad", p.Edad));
            parametros.Add(new SqlParameter("@admin", p.Admin));
            parametros.Add(new SqlParameter("@imagen", p.Foto));

            db.storeProcedureDB("actualizaUsuario", parametros); 
        }    
    }
}
