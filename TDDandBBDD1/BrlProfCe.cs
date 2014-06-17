using System.Collections.Generic;
using System.Linq;

namespace TDDandBBDD1
{
    public class BrlProfCE
    {
        public List<Familiar> familiares { get; set; }
        public List<Familiar> conyuges { get; set; }
        public Familiar conviviente { get; set; }
        private string apellido { get; set; }
        private string nombre { get; set; }
        public long legajo { get; set; }

        public BrlProfCE()
        {
            familiares = new List<Familiar>();
        }

        public void agregarFamiliar(Familiar objFamiliar)
        {
            familiares.Add(objFamiliar);
        }

        public List<Familiar> leerFamiliares()
        {
            return familiares;
        }

        public bool tieneConyuge()
        {
            return (conyuges != null);
        }

        public bool tieneConyugeFallecido()
        {
            return conyuges != null && conyuges.Aggregate(false, (current, conyuge) => current || conyuge.esFallecido());
        }

        public bool tieneConviviente()
        {
            return conviviente != null;
        }

        public void guardarNombre(string strNombre)
        {
            nombre = strNombre;
        }

        public void guardarApellido(string strApellido)
        {
            apellido = strApellido;
        }

        public string consultarNombreYApellido()
        {
            return nombre + " " + apellido;
        }
        
    }
}
