using KRAKEN.Core.ValidacoesDeDominio.Validacoes;
using Xunit;

namespace KRAKEN.Core.ValidacoesDeDominio.Testes.TestesDeContratos
{
    public class ContratoDeValidacaoDeBooleansTeste
    {
        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Booleans")]
        [Fact(DisplayName= "DeveRetornarVerdadeiroQuandoValorForFalso")]
        public void DeveRetornarVerdadeiroQuandoValorForFalso()
        {
            var valor = false;

            var contrato = new Contrato()
                .Requer()
                .VerificarSeVerdadeiro(valor, "valor", "O valor é falso");
            
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Booleans")]
        [Fact(DisplayName = "DeveRetornarFalsoQuandoValorForVerdadeiro")]
        public void DeveRetornarFalsoQuandoValorForVerdadeiro()
        {
            var valor = true;

            var contrato = new Contrato()
                .Requer()
                .VerificarSeFalso(valor, "valor", "O valor é verdaeiro");

            Assert.False(contrato.Valido);
        }
    }
}
