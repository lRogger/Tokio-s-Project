namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string cedula;
        private string correo;
        private int edad;
        private bool admin;
        private byte[] foto;
        private string password;

        public Persona()
        {
            this.nombre = "";
            this.cedula = "";
            this.correo = "";
            this.password = "";
            this.edad = 0;
            this.admin = false;
            this.foto = new byte[0];
        }

        public Persona(string nombre, string cedula, string correo,
            int edad, bool admin, byte[] foto, string password)
        {
            this.password = password;
            this.nombre = nombre;
            this.cedula = cedula;
            this.correo = correo;
            this.edad = edad;
            this.admin = admin;
            this.foto = foto;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Edad { get => edad; set => edad = value; }
        public bool Admin { get => admin; set => admin = value; }
        public byte[] Foto { get => foto; set => foto = value; }
        public string Password { get => password; set => password = value; }
    }
}