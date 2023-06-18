using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Registros
    {

        private int id;
        private DateTime fecha;
        private Persona usuario;
        private Prenda producto;
        private MateriaPrima materiaPrima;
        private string nombreProducto;
        private string descripcion;
        private int cantidad;

        public Registros( )
        {
            this.id = 0;
            this.fecha = DateTime.Now;
            this.usuario = new Persona();
            this.producto = new Prenda();
            this.materiaPrima = new MateriaPrima();
            this.nombreProducto = "";
            this.descripcion = "";
            this.cantidad = 0;
        }

        public Registros(int id, DateTime fecha, Persona usuario, Prenda producto, MateriaPrima materiaPrima,string nombreProducto, string descripcion, int cantidad)
        {
            this.id = id;
            this.fecha = fecha;
            this.usuario = usuario;
            this.producto = producto;
            this.materiaPrima = materiaPrima;
            this.nombreProducto = nombreProducto;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Persona Usuario { get => usuario; set => usuario = value; }
        public Prenda Producto { get => producto; set => producto = value; }
        public MateriaPrima MateriaPrima { get => materiaPrima; set => materiaPrima = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value;}
    }
}