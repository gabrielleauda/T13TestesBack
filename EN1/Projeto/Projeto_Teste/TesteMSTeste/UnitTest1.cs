using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto_Teste;


namespace TesteMSTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            var resultado = Operacoes.Somar(pNum, sNum);

            Assert.AreEqual(rNum, resultado);
        }

        [TestMethod]
        [DataRow (1, 1, 2)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            var resultado = Operacoes.Somar(pNum, sNum);

            Assert.AreEqual(rNum, resultado);
        }

    }
}