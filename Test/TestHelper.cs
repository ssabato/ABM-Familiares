using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;
using TDDandBBDD1;

namespace Test
{
    public class TestHelper
    {

        static IProfCeBuilder _objConcreteBuilder { get; set; }

        public TestHelper(IProfCeBuilder objConcreteBuilder)
        {
            _objConcreteBuilder = objConcreteBuilder; 
        }

        public BrlProfCE buildProf()
        {
            Builder.BrlProfCeDirector objDirector = new BrlProfCeDirector(_objConcreteBuilder);
            return objDirector.construir(); 
        }

    }
}
