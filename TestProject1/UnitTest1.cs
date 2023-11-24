using EDemoWeb;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var calcolatore = new Calcolatore();
            var a = 3;
            var b = 5;
            var risultato = calcolatore.Somma(a, b);
            Assert.AreEqual(8, risultato);
        }
    }
}