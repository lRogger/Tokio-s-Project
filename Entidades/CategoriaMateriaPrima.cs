using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CategoriaMateriaPrima
    {
        private int id;
        private string nombreCategoria;
        private string medidaCategoria;
        public CategoriaMateriaPrima()
        {
        }
        public CategoriaMateriaPrima(int id, string nombreCategoria, string medidaCategoria)
        {
            this.id = id;
            this.nombreCategoria = nombreCategoria;
            this.medidaCategoria = medidaCategoria;
        }
        public int Id { get => id; set => id = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public string MedidaCategoria { get => medidaCategoria; set => medidaCategoria = value;}
    }
}
