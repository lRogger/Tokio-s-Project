using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Prenda
    {

        private int id;
        private string categoria;
        private string talla;
        private string nombre;
        private string descripcion;
        private string tipo;
        private string color;
        private int stock;
        private double precio;

        

        public Prenda(int id, string categoria, string talla, string nombre, string descripcion, string tipo, string color, int stock, double precio)
        {
            this.id = id;
            this.categoria = categoria;
            this.talla = talla;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipo = tipo;
            this.color = color;
            this.stock = stock;
            this.precio = precio;
        }

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Talla { get => talla; set => talla = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Color { get => color; set => color = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
