using KRAKEN.Core.ValidacoesDeDominio.Validacoes;
using Xunit;

namespace KRAKEN.Core.ValidacoesDeDominio.Testes.TestesDeContratos
{
    public class ContratoDeValidacaoDeCepTeste
    {
        [TraitAttribute("Categoria", "Testes de Contrato de ceps")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoCepForVazio")]
        public void DeveRetornarNotificacaoQuandoCepForVazio()
        {
            var cep = string.Empty;

            var contrato = new Contrato()
              .Requer()
              .VerificarSeCepVazio(cep,"cep","cep vazio");

            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de ceps")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoCepNaoForVazio")]
        public void NaoDeveRetornarNotificacaoQuandoCepNaoForVazio()
        {
            var cep = "24130-110";

            var contrato = new Contrato()
              .Requer()
              .VerificarSeCepVazio(cep, "cep", "cep vazio");

            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de ceps")]
        [Fact(DisplayName = "DeveRetornarVerdadeiroQNaoDeveRetornarNotificacaoQuandoCepForValidoEForFormatadouandoValorForFalso")]
        public void NaoDeveRetornarNotificacaoQuandoCepForValidoEForFormatado()
        {
            var cep = "24130-110";

            var contrato = new Contrato()
              .Requer()
              .VerificarSeCepVazio(cep, "cep", "cep vazio");

            Assert.Equal(0, contrato.Notificacoes.Count);
        }
    }
}
