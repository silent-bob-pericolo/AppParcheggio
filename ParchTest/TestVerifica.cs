using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parchimetro;

namespace ParchTest
{
    [TestClass]
    public class TestVerifica
    {
        [TestMethod]
        public void TestMethod1()
        {
            int ore = 4;
            double tariffa = 1;
            double risposta_aspettata = 4;
            double risposta_effettiva = Gestione.TariffaB(ore, tariffa);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int ore = 6;
            double tariffa = 15;
            double risposta_aspettata = 15;
            double risposta_effettiva = Gestione.TariffaA(ore, tariffa);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int ore = 2;
            double tariffa = 1.20;
            double risposta_aspettata = 1.20;
            double risposta_effettiva = Gestione.TariffaC(ore, tariffa);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);
        }

    }
}
