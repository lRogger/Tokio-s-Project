namespace Entidades
{
    public class Proveedor
    {
        private int id;
        private string nombre;
        private string cedula_ruc;
        private string correo;
        private string telefono;
        private bool activo;
        public Proveedor()
        {
            this.id = 0;
            this.nombre = String.Empty;
            this.cedula_ruc = String.Empty;
            this.correo = String.Empty;
            this.telefono = String.Empty;
            this.activo = false;
        }

        public Proveedor(int id, string nombre, string cedula_ruc, string correo, string telefono, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Cedula_ruc = cedula_ruc;
            Correo = correo;
            Telefono = telefono;
            Activo = activo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula_ruc { get => cedula_ruc; set => cedula_ruc = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}