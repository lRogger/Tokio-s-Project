
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
