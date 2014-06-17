using TDDandBBDD1;

namespace Builder
{
    public class ProfCeBuilder : IProfCeBuilder
    {
        public BrlProfCE construir()
        {
            BrlProfCE objProfCe = new BrlProfCE();
            return objProfCe;
        }
    }
}
