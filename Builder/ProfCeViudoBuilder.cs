using System.Collections.Generic;
using TDDandBBDD1;

namespace Builder
{
    public class ProfCeViudoBuilder : IProfCeBuilder
    {
        public BrlProfCE construir()
        {
            BrlProfCE objProfCe = new BrlProfCE();
            Familiar objFamiliar = new Familiar();
            objFamiliar.defuncion();
            objProfCe.conyuges = new List<Familiar>();
            objProfCe.conyuges.Add(objFamiliar);
            return objProfCe;
        }
    }
}
