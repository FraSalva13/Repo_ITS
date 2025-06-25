using CalcolatriceLib;
namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSomma()
        {
            //crea test della somma
            CalcolatriceLib.Calcolatrice calcolatrice = new CalcolatriceLib.Calcolatrice();
            double risultato = calcolatrice.Somma(2, 3);
            Assert.AreEqual(5, risultato, "La somma di 2 e 3 dovrebbe essere 5");
        }
        [TestMethod]

        public void TestSommaConZero()
        {
            //crea test della somma con zero
            Calcolatrice calcolatrice = new Calcolatrice();
            double risultato = calcolatrice.Somma(2, 0);
            Assert.AreEqual(2, risultato, "La somma di 2 e 0 dovrebbe essere 2");
        }
    }
}
