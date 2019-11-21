using KRAKEN.Core.ValidacoesDeDominio.Validacoes;
using Xunit;

namespace KRAKEN.Core.ValidacoesDeDominio.Testes.TestesDeContratos
{
    public class ContratoDeValidacaoDeTelefonesTeste
    {
        [TraitAttribute("Categoria", "Testes de Contrato de Telefones")]
        [Theory(DisplayName = "DeveRetornarNotificacaoQuandoTelefoneCelularForInvalido")]
        [InlineData("(11)99878-4567AAAA", "(21)99878-4567456")]
        public void DeveRetornarNotificacaoQuandoTelefoneCelularForInvalido(string telefoneUm, string telefoneDois)
        {
            var contrato = new Contrato()
                .Requer()
                .VerificarSeTelefoneCelularComDDDEValido(telefoneUm, "valor", "O valor é falso")
                .VerificarSeTelefoneCelularComDDDEValido(telefoneDois, "valor", "O valor é falso");

            Assert.Equal(2, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de Telefones")]
        [Theory(DisplayName = "DeveRetornarNotificacaoQuandoDDDTelefoneCelularForInvalido")]
        [InlineData("(11A)99878-4567AAAA")]
        public void DeveRetornarNotificacaoQuandoDDDTelefoneCelularForInvalido(string telefoneUm)
        {
            var contrato = new Contrato()
                .Requer()
                .VerificarSeTelefoneCelularComDDDEValido(telefoneUm, "valor", "O valor é falso");

            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de Telefones")]
        [Theory(DisplayName = "NaoDeveRetornarNotificacaoQuandoTelefoneCelularForValido")]
        [InlineData("(21)99876-2345", "(21)999999999", "(13)300-413")]
        public void NaoDeveRetornarNotificacaoQuandoTelefoneCelularForValido(string telefoneUm,string telefoneDois,string telefoneTres)
        {
            var contrato = new Contrato()
                .Requer()
                .VerificarSeTelefoneCelularComDDDEValido(telefoneUm, "valor", "O valor é falso")
                .VerificarSeTelefoneCelularComDDDEValido(telefoneDois, "valor", "O valor é falso")
                .VerificarSeTelefoneCelularComDDDEValido(telefoneTres, "valor", "O valor é falso");

            Assert.Equal(0, contrato.Notificacoes.Count);
        }
    }
}
