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
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoCepForInvalido")]
        public void DeveRetornarNotificacaoQuandoCepForInvalido()
        {
            var cep = "24130-123456";

            var contrato = new Contrato()
              .Requer()
              .VerificarSeCepValido(cep, "cep", "cep inválido")
              .VerificarSeCepVazio(cep, "cep", "cep vazio");

            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de ceps")]
        [Theory(DisplayName = "NaoDeveRetornarNotificacaoQuandoCepForValido")]
        [InlineData("24130-110", "24130110")]
        public void NaoDeveRetornarNotificacaoQuandoCepForValido(string cepComMascara,string cepSemMascara)
        {
            var contratoCepComMascara = new Contrato()
              .Requer()
              .VerificarSeCepValido(cepComMascara, "cep", "cep inválido")
              .VerificarSeCepVazio(cepComMascara, "cep", "cep vazio");

            var contratoCepSemMascara = new Contrato()
           .Requer()
           .VerificarSeCepValido(cepSemMascara, "cep", "cep inválido")
           .VerificarSeCepVazio(cepSemMascara, "cep", "cep vazio");

            Assert.Equal(0, contratoCepComMascara.Notificacoes.Count);
            Assert.Equal(0, contratoCepSemMascara.Notificacoes.Count);
        }
    }
}
