﻿using Xunit;
using TesteIMC;

namespace TesteIMCxUnit
{
   
    public class CalculoIMCTests
    {
        [Fact]
        public void CalculaIMC_RetornarResultado()
        {
            double peso = 110;
            double altura = 1.79;

            var resultado = Operacoes.CalcularIMC(peso, altura);

            Assert.Equal(34.33, resultado);
        }

        [Theory]
        [InlineData(80, 1.79, 24.97)]
        [InlineData(100, 1.79, 31.21)]
        public void CalcularIMC_RetornaResultado_Para_Uma_ListaDeValores(double primeiroNumero, double segundoNumero, double resultadoEsperado)
        {
            var resultadoIMC = Operacoes.CalcularIMC(primeiroNumero, segundoNumero);
            Assert.Equal(resultadoEsperado, resultadoIMC);

        }


    }
}
