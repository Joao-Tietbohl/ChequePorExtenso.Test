using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChequePorExtenso.Test
{
    [TestClass]
    public class Testes
    {
        Actions conversor = new Actions();

        [TestMethod]
        [DataRow(1, "Um")]
        [DataRow(2, "Dois")]
        [DataRow(3, "Três")]
        [DataRow(4, "Quatro")]
        [DataRow(5, "Cinco")]
        [DataRow(6, "Seis")]
        [DataRow(7, "Sete")]
        [DataRow(8, "Oito")]
        [DataRow(9, "Nove")]
        [DataRow(10, "Dez")]
        
        [DataRow(11, "Onze")]
        [DataRow(12, "Doze")]
        [DataRow(13, "Treze")]
        [DataRow(14, "Quatorze")]
        [DataRow(15, "Quinze")]
        [DataRow(16, "Dezesseis")]
        [DataRow(17, "Dezessete")]
        [DataRow(18, "Dezoito")]
        [DataRow(19, "Dezenove")]
        [DataRow(20, "Vinte")]

        [DataRow(21, "Vinte e Um")]
        [DataRow(22, "Vinte e Dois")]
        [DataRow(23, "Vinte e Três")]
        [DataRow(24, "Vinte e Quatro")]
        [DataRow(25, "Vinte e Cinco")]
        [DataRow(26, "Vinte e Seis")]

        [DataRow(36, "Trinta e Seis")]
        [DataRow(55, "Cinquenta e Cinco")]
        [DataRow(78, "Setenta e Oito")]
        [DataRow(99, "Noventa e Nove")]


        public void Converter_Unidades_E_Dezenas(int numero, string resultadoEsperado)
        {
            //Arrange
            int numeroParaConversao = numero;

            //Action
            var resultadoConversao = conversor.Converter(numeroParaConversao);
            
            //Assert

            Assert.AreEqual(resultadoEsperado, resultadoConversao);
        }

        [TestMethod]
        [DataRow(105, "Cento e Cinco")]
        [DataRow(155, "Cento e Cinquenta e Cinco")]
        [DataRow(148, "Cento e Quarenta e Oito")]
        [DataRow(169, "Cento e Sessenta e Nove")]

        public void Converter_Centenas(int numero, string resultadoEsperado)
        {
            //Arrange
            int numeroParaConversao = numero;

            //Action
            var resultadoConversao = conversor.Converter(numeroParaConversao);

            //Assert

            Assert.AreEqual(resultadoEsperado, resultadoConversao);
        }
    }
}
