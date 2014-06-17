using TDDandBBDD1;

namespace Builder
{
    public class ProfCeSolteroBuilder : IProfCeBuilder
    {
        public BrlProfCE construir()
        {
            return new BrlProfCE();
        }
    }
}
