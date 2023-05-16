using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class CtrlProveedor
    {
        DBProveedor dataBase = new DBProveedor();
        public List<Proveedor> ListarProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();

            lista = dataBase.CargarDatosProveedores();

            return lista;
        }

        public bool GuardarProveedor(string nombre, string cedula, string correo, string telefono)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Nombre = nombre.Trim();
            proveedor.Cedula_ruc = cedula.Trim();
            proveedor.Correo = correo.Trim().ToLower();
            proveedor.Telefono = telefono.Trim();

            return dataBase.InsertarProveedor(proveedor);
        }

        public bool EditarProveedor(string nombre, string cedula, string correo, string telefono)
        {
            Proveedor proveedor =new Proveedor();
            proveedor.Nombre = nombre;
            proveedor.Cedula_ruc = cedula;
            proveedor.Correo = correo;
            proveedor.Telefono = telefono;

            return dataBase.EditarProveedor(proveedor);
        }

        public void EliminarProveedor(string id)
        {
            dataBase.BorrarProveedor(id);
        }
    }
}
