using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Controladores
{
    public class CtrlMateriaPrima
    {
        DBMateriaPrima dataBase = new DBMateriaPrima();
        public List<MateriaPrima> ListarMateriaPrima()
        {
            List<MateriaPrima> lista = new List<MateriaPrima>();

            lista = dataBase.CargarDatosMateriaPrima();
            
            return lista;
        }

    }
}
