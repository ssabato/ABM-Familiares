using System.Collections.Generic;
using System.Linq;
using Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDandBBDD1;
using Test;

namespace Test
{
    [TestClass]
    public class UnitTestABMFamiliares
    {
        [TestMethod]
        public void testMethodAgregarFamiliarAMatriculadoDevuelve1Familiar()
        {
            BrlProfCE objMatriculado = new TestHelper(new ProfCeBuilder()).buildProf(); 
            Familiar objFamiliar = new Familiar();
            objMatriculado.agregarFamiliar(objFamiliar);
            Assert.IsTrue(objMatriculado.familiares.Count == 1, "No coincide la cantidad de familiares");
        }

        [TestMethod]
        public void testMethodLeerFamiliaresMatriculadoDevuelve1Familiar()
        {
            BrlProfCE objMatriculado = new TestHelper(new ProfCeBuilder()).buildProf();
            Familiar objFamiliar = new Familiar();
            objMatriculado.agregarFamiliar(objFamiliar);
            Assert.IsTrue(objMatriculado.leerFamiliares().Count ==1, "La cantidad de familiares no coincide");
        }

        [TestMethod]
        public void testMethodLeerMatriculado()
        {
            WflLeerMatriculado objWfl = new WflLeerMatriculado();
            List<Matriculados> objMatriculados = objWfl.leerMatriculados();
            Assert.IsTrue(objMatriculados.Count == 1, "La cantidad no coincide " + objMatriculados.Count);
        }

        [TestMethod]
        public void testAgregarHijoDeJuanPerezLlamadoJoseDevuelveJoseAlConsultarNombreDelHijo()
        {
            BrlProfCE objMatriculado = new TestHelper(new ProfCeBuilder()).buildProf();
            Familiar objFamiliar = new Familiar();
            objFamiliar.cargarNombre("Jose");
            objMatriculado.agregarFamiliar(objFamiliar);
            string resultado = objMatriculado.leerFamiliares().First().leerNombre();
            Assert.AreEqual(resultado, "Jose");
        }
        
        [TestMethod]
        public void testGrabarNombreYApellidoJuanPerezDevuelveJuanPerez()
        {
            BrlProfCE objMatriculado = new TestHelper(new ProfCeBuilder()).buildProf();
            objMatriculado.guardarNombre("Juan");
            objMatriculado.guardarApellido("Perez");
            string resultado = objMatriculado.consultarNombreYApellido();
            Assert.AreEqual("Juan Perez", resultado);
        }

        [TestMethod]
        public void testGrabarFamiliarEnBbdd()
        {
            Familiar familiar = new Familiar();
            List<Familiar> familiares = new List<Familiar>();
            BrlProfCE objMatriculado = new TestHelper(new ProfCeBuilder()).buildProf();
            objMatriculado.agregarFamiliar(familiar);
            PersistenciaFamiliares persistenciaFamiliares = new PersistenciaFamiliares();
            familiares = persistenciaFamiliares.leerFamiliares(objMatriculado.legajo);
            Familiar resultado = familiares.FirstOrDefault();
            Assert.AreEqual("expected", resultado.leerNombre());
        }
    }

    
}
