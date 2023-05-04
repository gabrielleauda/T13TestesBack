using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteIMC;


namespace TestarIMC
{
    public class CalculoIMCTeste
    {
        [TestMethod]
        public void ClacularIMC()
        {
            double peso = 110;
            double altura = 1.79;

            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            Assert.AreEqual(34.33, resultadoIMC);
        }
    }
}
