using Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDandBBDD1;


namespace Test
{
    [TestClass]
    public class UnitTestEstadosCiviles
    {
        [TestMethod]
        public void testMatriculadoEstadoCivilCasadoDebeTenerConyuge()
        {
            BrlProfCE objMatriculado = new TestHelper(new ProfCeConConyugeBuilder()).buildProf();
            Assert.IsTrue(objMatriculado.tieneConyuge(), "El profesional no tiene conyuge, por lo tanto no puede estar casado.");
        }

        [TestMethod]
        public void testMatriculadoEstadoCivilSolterNoDebeTenerConyuge()
        {
            BrlProfCE objMatriculado = new TestHelper(new ProfCeSolteroBuilder()).buildProf(); 
            Assert.IsTrue(!objMatriculado.tieneConyuge(), "El profesional es soltero, por lo tanto no puede tener conyuge");
        }

        [TestMethod]
        public void testMatriculadoViudoDebeTenerConyugeFallecido()
        {
            BrlProfCE objMatriculado = new TestHelper(new ProfCeViudoBuilder()).buildProf(); 
            Assert.IsTrue(objMatriculado.tieneConyugeFallecido());
        }

        [TestMethod]
        public void testMatriculadoSolteroFallaConyugeFallecido()
        {
            BrlProfCE objMatriculado = new TestHelper(new ProfCeSolteroBuilder()).buildProf(); 
            Assert.IsFalse(objMatriculado.tieneConyugeFallecido());
        }

        [TestMethod]
        public void testMatriculadoViudoPuedeTenerConviviente()
        {
            BrlProfCE objMatriculado = new TestHelper(new ProfCeViudoConConvivienteBuilder()).buildProf(); 
            Assert.IsTrue(objMatriculado.tieneConviviente());
        }

        [TestMethod]
        public void testDivorciadoNoPuedeTenerConyuge()
        {
            BrlProfCE objMatriculado = new TestHelper(new ProfCeDivorciadoBuilder()).buildProf(); 
            Assert.IsFalse(objMatriculado.tieneConyuge());
        }
    }
}
