using System.Collections.Generic;
using TDDandBBDD1;

namespace Builder
{
    public class ProfCeConConyugeBuilder : IProfCeBuilder
    {
        public BrlProfCE construir()
        {
            BrlProfCE objProfCe = new BrlProfCE();
            objProfCe.conyuges = new List<Familiar>();
            return objProfCe;
        }
    }
}
