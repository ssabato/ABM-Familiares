using TDDandBBDD1;

namespace Builder
{
    public class ProfCeDivorciadoBuilder : IProfCeBuilder
    {
        public BrlProfCE construir()
        {
            return new BrlProfCE();
        }
    }
}
