using System.Collections.Generic;
using Builder;

namespace TDDandBBDD1
{
    public class ProfCeViudoConConvivienteBuilder : IProfCeBuilder
    {
        public BrlProfCE construir()
        {
            BrlProfCE objProf = new BrlProfCE();
            Familiar objConyuge = new Familiar();
            Familiar objConviviente = new Familiar();
            objConyuge.defuncion();
            objProf.conyuges = new List<Familiar> {objConyuge};
            objProf.conviviente = objConviviente;
            return objProf;
        }
    }
}
