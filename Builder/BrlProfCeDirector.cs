using TDDandBBDD1;

namespace Builder
{
    public class BrlProfCeDirector
    {
        IProfCeBuilder _concreteBuilder { get; set;} 

        public BrlProfCeDirector(IProfCeBuilder profCeBuilder)
        {
            _concreteBuilder = profCeBuilder;
        }

        public BrlProfCE construir()
        {
            return _concreteBuilder.construir();
        }
    }
}
