using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class DBRegistros
    {
        public DBRegistros() { }


        public List<Registros> LeerRegistros()
        {
            DataBase db = new DataBase();
            SqlDataReader reader = db.SpConsulta("ObtenerRegistrosCompleto");
            var listaRegistros = new List<Registros>();

            while (reader.Read())
            {
                Registros registro = new Registros();
                registro.Id = reader.GetInt32(0);
                registro.Fecha = reader.GetDateTime(1);

                Persona usuario = new Persona();
                usuario.Id = reader.GetInt32(2);
                usuario.Cedula = reader.GetString(3);
                usuario.Nombre = reader.GetString(4);
                usuario.Correo = reader.GetString(5);
                usuario.Edad = reader.GetInt32(6);
                usuario.Password = reader.GetString(7);
                usuario.Admin = reader.GetBoolean(8);
                usuario.Foto = reader.GetString(9);
                registro.Usuario = usuario;

                Prenda producto = new Prenda();
                producto.Id = reader.GetInt32(10);
                producto.Categoria = reader.GetString(11);
                producto.Talla = reader.GetString(12);
                producto.Nombre = reader.GetString(13);
                producto.Descripcion = reader.GetString(14);
                producto.Color = reader.GetString(15);
                producto.Stock = reader.GetInt32(16);
                producto.Precio = reader.GetDouble(17);
                producto.Activo = reader.GetBoolean(18);
                registro.Producto = producto;

                registro.Descripcion = reader.GetString(19);
                registro.Cantidad = reader.GetInt32(20);

                listaRegistros.Add(registro);
            }

            return listaRegistros;
        }

        public void CrearRegistro(Registros registro)
        {
            new DataBase().instruccionDB($"INSERT INTO Registros (IdUsuario, Descripcion, " +
                $"Cantidad, IdProducto) VALUES ({registro.Usuario.Id}," +
                $"'{registro.Descripcion}',{registro.Cantidad},{registro.Producto.Id})");
        }
    }
}
