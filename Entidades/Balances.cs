using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Balances
    {

        private int id;
        private string producto;
        private DateTime fecha;
        private double valor;

        public int Id { get => id; set => id = value; }
        public string Producto { get => producto; set => producto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Valor { get => valor; set => valor = value; }

        public Balances()
        {
            this.id = 0;
            this.producto = "";
            this.fecha = DateTime.Now;
            this.valor = 0;
        }

        public Balances(int id, string producto, DateTime fecha, double valor)
        {
            Id = id;
            Producto = producto;
            Fecha = fecha;
            Valor = valor;
        }
    }
}
