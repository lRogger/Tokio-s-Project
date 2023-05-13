﻿namespace Entidades
{
    public class MateriaPrima
    {
        private int id;
        private string nombre;
        private Proveedor proveedor;
        private int stock;
        private double precio;
        private DateTime fechaCompra;

        public MateriaPrima()
        {
            this.id = 0;
            this.nombre = String.Empty;
            this.proveedor = new Proveedor();
            this.stock = 0;
            this.precio = 0;
            this.fechaCompra = DateTime.Now;
        }

        public MateriaPrima(int id, string nombre, Proveedor proveedor, int stock, double precio, DateTime fechaCompra)
        {
            Id = id;
            Nombre = nombre;
            Proveedor = proveedor;
            Stock = stock;
            Precio = precio;
            FechaCompra = fechaCompra;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Proveedor Proveedor { get => proveedor; set => proveedor = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
    }
}