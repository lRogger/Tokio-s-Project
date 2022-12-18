using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Modelos
{
    internal class Persona
    {

        private int id;
        private string nombre;
        private string cedula;
        private string correo;
        private int edad;
        private string password;
        private bool admin;
        private byte[] foto;


        public Persona(string nombre, string cedula, string correo,
            int edad, string password, bool admin, byte[] foto)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.correo = correo;
            this.edad = edad;
            this.password = password;
            this.admin = admin;
            this.foto = foto;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Password { get => password; set => password = value; }
        public bool Admin { get => admin; set => admin = value; }
        public byte[] Foto { get => foto; set => foto = value; }
    }
}
