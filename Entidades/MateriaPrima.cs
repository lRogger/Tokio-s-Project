namespace Entidades
{
    public class MateriaPrima
    {
        private int id;
        private string categoria;
        private string nombre;
        private string descripcion;
        private Proveedor proveedor;
        private int stock;
        private double precio;
        private DateTime fechaCompra;
        private String color;

        public MateriaPrima()
        {
            this.id = 0;
            this.categoria = String.Empty;
            this.nombre = String.Empty;
            this.descripcion = String.Empty;
            this.proveedor = new Proveedor();
            this.stock = 0;
            this.precio = 0;
            this.fechaCompra = DateTime.Now;
            this.color = String.Empty;
        }

        public MateriaPrima(int id, string categoria, string nombre, string descripcion, Proveedor proveedor, int stock, double precio, DateTime fechaCompra, string color)
        {
            Id = id;
            Categoria = categoria;
            Nombre = nombre;
            Descripcion = descripcion;
            Proveedor = proveedor;
            Stock = stock;
            Precio = precio;
            FechaCompra = fechaCompra;
            Color = color;
        }

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Proveedor Proveedor { get => proveedor; set => proveedor = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public string Color { get => color; set => color = value; }
    }
}