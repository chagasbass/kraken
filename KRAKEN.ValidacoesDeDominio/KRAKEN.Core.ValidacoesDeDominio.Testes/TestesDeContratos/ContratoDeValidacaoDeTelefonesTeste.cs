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
        [InlineData("(11A)99878-4567")]
        public void DeveRetornarNotificacaoQuandoDDDTelefoneCelularForInvalido(string telefoneUm)
        {
            var contrato = new Contrato()
                .Requer()
                .VerificarSeTelefoneCelularComDDDEValido(telefoneUm, "valor", "O valor é falso");

            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de Telefones")]
        [Theory(DisplayName = "NaoDeveRetornarNotificacaoQuandoDDDTelefoneCelularForemValidos")]
        [InlineData("(11)99878-4567")]
        public void NaoDeveRetornarNotificacaoQuandoDDDTelefoneCelularForemValidos(string telefoneUm)
        {
            var contrato = new Contrato()
                .Requer()
                .VerificarSeTelefoneCelularComDDDEValido(telefoneUm, "valor", "O valor é falso");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de Telefones")]
        [Theory(DisplayName = "NaoDeveRetornarNotificacaoQuandoTelefoneCelularForValido")]
        [InlineData("(21)99876-2345", "(21)999999999", "(13)300-413")]
        public void NaoDeveRetornarNotificacaoQuandoTelefoneCelularForValido(string telefoneUm, string telefoneDois, string telefoneTres)
        {
            var contrato = new Contrato()
                .Requer()
                .VerificarSeTelefoneCelularComDDDEValido(telefoneUm, "valor", "O valor é falso")
                .VerificarSeTelefoneCelularComDDDEValido(telefoneDois, "valor", "O valor é falso")
                .VerificarSeTelefoneCelularComDDDEValido(telefoneTres, "valor", "O valor é falso");

            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de Telefones")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoTelefoneEstiverSemMascaraEDDDEContiverMaisDeNoveNumeros")]
        public void DeveRetornarNotificacaoQuandoTelefoneEstiverSemMascaraEDDDEContiverMaisDeNoveNumeros()
        {
            var telefoneInvalido = "9999999999";

            var contrato = new Contrato()
                .Requer()
                .VerificarSeTelefoneCelularSemDDDEValido(telefoneInvalido, "telefone", "O telefone é invalido");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de Telefones")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoTelefoneEstiverSemMascaraEDDDENaoIniciarComNumeroNove")]
        public void DeveRetornarNotificacaoQuandoTelefoneEstiverSemMascaraEDDDENaoIniciarComNumeroNove()
        {
            var telefoneInvalido = "899999999";

            var contrato = new Contrato()
                .Requer()
                .VerificarSeTelefoneCelularSemDDDEValido(telefoneInvalido, "telefone", "O telefone é invalido");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de Telefones")]
        [Theory(DisplayName = "DeveRetornarNotificacaoQuandoTelefoneEstiverSemMascaraEDDDEContiverNumerosRepetidos")]
        [InlineData("111111111","222222222","333333333","444444444","555555555","666666666","777777777","888888888","000000000")]
        public void DeveRetornarNotificacaoQuandoTelefoneEstiverSemMascaraEDDDEContiverNumerosRepetidos(
            string telefoneUm, string telefoneDois, string telefoneTres, string telefoneQuatro, string telefoneCinco,
            string telefoneSeis, string telefoneSete, string telefoneOito, string telefoneZero)
        {
            var contrato = new Contrato()
                .Requer()
                .VerificarSeTelefoneCelularSemDDDEValido(telefoneUm, "telefone", "O telefone é invalido")
                .VerificarSeTelefoneCelularSemDDDEValido(telefoneDois, "telefone", "O telefone é invalido")
                .VerificarSeTelefoneCelularSemDDDEValido(telefoneTres, "telefone", "O telefone é invalido")
                .VerificarSeTelefoneCelularSemDDDEValido(telefoneQuatro, "telefone", "O telefone é invalido")
                .VerificarSeTelefoneCelularSemDDDEValido(telefoneCinco, "telefone", "O telefone é invalido")
                .VerificarSeTelefoneCelularSemDDDEValido(telefoneSeis, "telefone", "O telefone é invalido")
                .VerificarSeTelefoneCelularSemDDDEValido(telefoneSete, "telefone", "O telefone é invalido")
                .VerificarSeTelefoneCelularSemDDDEValido(telefoneOito, "telefone", "O telefone é invalido")
                .VerificarSeTelefoneCelularSemDDDEValido(telefoneZero, "telefone", "O telefone é invalido");

            Assert.False(contrato.Valido);
            Assert.Equal(18, contrato.Notificacoes.Count);
        }
    }
}
