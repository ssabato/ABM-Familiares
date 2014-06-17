using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDandBBDD1
{
    public class PersistenciaFamiliares
    {
        public List<Familiar> leerFamiliares(long legajo)
        {
            //Voy a la base o donde corresponda luego
            //Primero escribo el minimo test para que pase.
            List<Familiar> familiares = new List<Familiar>();
            Familiar familiar = new Familiar();
            familiar.cargarNombre("expected");
            familiares.Add(familiar);
            return familiares;
        }
    }
}
