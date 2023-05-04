using Xunit;
using TesteIMC;

namespace TesteIMCxUnit
{
    public class ClassificarIMCTests
    {
        [Fact]
        public void ClassificarIMC_RetornaResultado()
        {
            double imc = 28;
            var resultado = Operacoes.ClassificarIMC(imc);
            Assert.Equal("Sobrepeso", resultado);
        }
        [Theory]
        [InlineData(28, "Sobrepeso")]
        [InlineData(31, "Obesidade I")]
        public void ClassificarIMC_RetornaResultado_Para_Uma_ListaDeValores(double primeiroNumero, string resultadoEsperado)
        {
            var resultadoDoImc = Operacoes.ClassificarIMC(primeiroNumero);
            Assert.Equal(resultadoEsperado, resultadoDoImc);
        }
    }
}
