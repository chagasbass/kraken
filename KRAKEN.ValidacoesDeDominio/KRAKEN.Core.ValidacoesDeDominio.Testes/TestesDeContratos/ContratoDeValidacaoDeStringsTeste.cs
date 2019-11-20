using KRAKEN.Core.ValidacoesDeDominio.Validacoes;
using Xunit;

namespace KRAKEN.Core.ValidacoesDeDominio.Testes.TestesDeContratos
{
    public class ContratoDeValidacaoDeStringsTeste
    {
        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForNaoNuloOuVazio")]
        public void DeveRetornarNotificacaoQuandoForNaoNuloOuVazio()
        {
            var valor = string.Empty;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoNuloOuVazio(valor,
                "valor", "O valor  não deve ser nulo ou vazio");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoNaoForNaoNuloOuVazio")]
        public void NaoDeveRetornarNotificacaoQuandoNaoForNaoNuloOuVazio()
        {
            var valor = "tem coisa";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoNuloOuVazio(valor,
                "valor", "O valor  Não deve ser nulo ou vazio");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForNaoNuloOuEspacoEmBranco")]
        public void DeveRetornarNotificacaoQuandoForNaoNuloOuEspacoEmBranco()
        {
            var valor = string.Empty;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoNuloOuEspacoEmBranco(valor,
                "valor", "O valor  não deve ser nulo ou vazio");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForNaoNuloOuEspacoEmBranco")]
        public void NaoDeveRetornarNotificacaoQuandoForNaoNuloOuEspacoEmBranco()
        {
            var valor = "tem coisa";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoNuloOuEspacoEmBranco(valor,
                "valor", "O valor  Não deve ser nulo ou vazio");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoNaoForNuloOuVazio")]
        public void DeveRetornarNotificacaoQuandoNaoForNuloOuVazio()
        {
            var valor = "haiuahiau";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNuloOuVazio(valor,
                "valor", "O valor   deve ser nulo ou vazio");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForNuloOuVazio")]
        public void NaoDeveRetornarNotificacaoQuandoForNuloOuVazio()
        {
            var valor = "";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNuloOuVazio(valor,
                "valor", "O valor  deve ser nulo ou vazio");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoNaoForDoTamanhoMinimo")]
        public void DeveRetornarNotificacaoQuandoNaoForDoTamanhoMinimo()
        {
            var primeiroValor = "teste";
            var segundoValor = string.Empty;
            var tamanhoMinimo = 10;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeTemTamanhoMinimo(primeiroValor, tamanhoMinimo,
                "valor", "O valor  deve conter o tamanho minimo");

            contrato.Requer()
            .VerificarSeTemTamanhoMinimo(segundoValor, tamanhoMinimo,
            "valor", "O valor  deve conter o tamanho minimo");

            Assert.False(contrato.Valido);
            Assert.Equal(2, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForDoTamanhoMinimo")]
        public void NaoDeveRetornarNotificacaoQuandoForDoTamanhoMinimo()
        {
            var primeiroValor = "teste";
            var segundoValor = "abcde";
            var tamanhoMinimo = 5;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeTemTamanhoMinimo(primeiroValor, tamanhoMinimo,
                "valor", "O valor  deve conter o tamanho minimo");

            contrato.Requer()
            .VerificarSeTemTamanhoMinimo(segundoValor, tamanhoMinimo,
            "valor", "O valor  deve conter o tamanho minimo");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoNaoForDoTamanhoMaximo")]
        public void DeveRetornarNotificacaoQuandoNaoForDoTamanhoMaximo()
        {
            var primeiroValor = "teste";
            var segundoValor = string.Empty;
            var tamanhoMinimo = 3;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeTemTamanhoMaximo(primeiroValor, tamanhoMinimo,
                "valor", "O valor  deve conter o tamanho maximo");

            contrato.Requer()
            .VerificarSeTemTamanhoMinimo(segundoValor, tamanhoMinimo,
            "valor", "O valor  deve conter o tamanho minimo");

            Assert.False(contrato.Valido);
            Assert.Equal(2, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoNaoForDoTamanhoMaximo")]
        public void NaoDeveRetornarNotificacaoQuandoNaoForDoTamanhoMaximo()
        {
            var primeiroValor = "teste";

            var tamanhoMaximo = 13;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeTemTamanhoMaximo(primeiroValor, tamanhoMaximo,
                "valor", "O valor  deve conter o tamanho maximo");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoNaoForDoTamanhoAdequado")]
        public void DeveRetornarNotificacaoQuandoNaoForDoTamanhoAdequado()
        {
            var primeiroValor = "teste";
            var segundoValor = string.Empty;
            var tamanhoIdeal = 3;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarTamanho(primeiroValor, tamanhoIdeal,
                "valor", "O valor  deve conter o tamanho ideal");

            contrato.Requer()
            .VerificarTamanho(segundoValor, tamanhoIdeal,
            "valor", "O valor  deve conter o tamanho ideal");

            Assert.False(contrato.Valido);
            Assert.Equal(2, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoNaoForDoTamanhoAdequado")]
        public void NaoDeveRetornarNotificacaoQuandoNaoForDoTamanhoAdequado()
        {
            var primeiroValor = "teste";

            var tamanhoMaximo = 5;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarTamanho(primeiroValor, tamanhoMaximo,
                "valor", "O valor  não deve conter o tamanho maximo");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoContiver")]
        public void DeveRetornarNotificacaoQuandoContiver()
        {
            var primeiroValor = "teste";

            var texto = "te";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeContem(primeiroValor, texto,
                "valor", "O valor  não pode conter o texto");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoNaoContiver")]
        public void NaoDeveRetornarNotificacaoQuandoNaoContiver()
        {
            var primeiroValor = "teste";

            var texto = "dsds";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeContem(primeiroValor, texto,
                "valor", "O valor  pode conter o texto");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoVerificarQueNaoSaoIguais")]
        public void DeveRetornarNotificacaoQuandoVerificarQueNaoSaoIguais()
        {
            var primeiroValor = "teste";

            var texto = "teste!";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeSaoIguais(primeiroValor, texto,
                "valor", "O valores  devem ser iguais");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoVerificarQueSaoIguais")]
        public void NaoDeveRetornarNotificacaoQuandoVerificarQueSaoIguais()
        {
            var primeiroValor = "teste";

            var texto = "teste";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeSaoIguais(primeiroValor, texto,
                "valor", "O valores  devem ser iguais");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoVerificarQueSaoIguais")]
        public void DeveRetornarNotificacaoQuandoVerificarQueSaoIguais()
        {
            var primeiroValor = "teste";

            var texto = "teste";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoSaoIguais(primeiroValor, texto,
                "valor", "O valores não  devem ser iguais");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoEmailForInvalido")]
        public void DeveRetornarNotificacaoQuandoEmailForInvalido()
        {
            var email = "teste@";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEmailValido(email,
                "valor", "O email é inválido");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoEmailForValido")]
        public void NaoDeveRetornarNotificacaoQuandoEmailForValido()
        {
            var email = "teste@teste.com";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEmailValido(email,
                "valor", "O valores não  devem ser iguais");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoEmailForValidoOuVazio")]
        public void DeveRetornarNotificacaoQuandoEmailForValidoOuVazio()
        {
            var emailVazio = "";
            var emailErrado = " tes";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEmailInvalidoOuVazio(emailVazio,
                "valor", "O Email é inválido");

            contrato.Requer()
              .VerificarSeEmailInvalidoOuVazio(emailErrado,
              "valor", "O Email é inválido");

            Assert.False(contrato.Valido);
            Assert.Equal(2, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoEmailForNaoValidoOuVazio")]
        public void NaoDeveRetornarNotificacaoQuandoEmailForNaoValidoOuVazio()
        {
            var email = "chagas.bass@gmail.com";
            
            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEmailInvalidoOuVazio(email,
                "valor", "O Email é inválido");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoNaoForDigito")]
        public void DeveRetornarNotificacaoQuandoNaoForDigito()
        {
            var email = "DESCUBRA";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeDigito(email,
                "valor", "Nao e digito");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForDigito")]
        public void NaoDeveRetornarNotificacaoQuandoForDigito()
        {
            var email = "10";

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeDigito(email,
                "valor", "Nao e digito");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForDeTamanhoMininoENaoForNuloOuVazio")]
        public void DeveRetornarNotificacaoQuandoForDeTamanhoMininoENaoForNuloOuVazio()
        {
            var valor = "10";
            var tamanhoMinimo = 4;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarTamanhoMinimoSeNaoForNuloOuVazio(valor,tamanhoMinimo,
                "valor", "Nao tem tamanho minimo");
          
            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForDeTamanhoMininoENaoForNuloOuVazio")]
        public void NaoDeveRetornarNotificacaoQuandoForDeTamanhoMininoENaoForNuloOuVazio()
        {
            var valor = "10";
            var tamanhoMinimo = 2;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarTamanhoMinimoSeNaoForNuloOuVazio(valor, tamanhoMinimo,
                "valor", "Nao tem tamanho minimo");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForNaoDeTamanhoMininoENaoForNuloOuVazio")]
        public void DeveRetornarNotificacaoQuandoForNaoDeTamanhoMininoENaoForNuloOuVazio()
        {
            var valor = "109090909";
            var tamanhoMinimo = 4;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarTamanhoMaximoSeNaoForNuloOuVazio(valor, tamanhoMinimo,
                "valor", "Nao tem tamanho minimo");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForNaoDeTamanhoMininoENaoForNuloOuVazio")]
        public void NaoDeveRetornarNotificacaoQuandoForNaoDeTamanhoMininoENaoForNuloOuVazio()
        {
            var valor = "10";
            var tamanhoMinimo = 2;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarTamanhoMaximoSeNaoForNuloOuVazio(valor, tamanhoMinimo,
                "valor", "Nao tem tamanho minimo");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForDeTamanhoExatoForNuloOuVazio")]
        public void DeveRetornarNotificacaoQuandoForDeTamanhoExatoForNuloOuVazio()
        {
            var valor = "108";
            var tamanhoMinimo = 2;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarTamanhoExatoSeNaoForNuloOuVazio(valor, tamanhoMinimo,
                "valor", "Nao tem tamanho minimo");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de String")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForDeTamanhoExatoForNuloOuVazio")]
        public void NaoDeveRetornarNotificacaoQuandoForDeTamanhoExatoForNuloOuVazio()
        {
            var valor = "10";
            var tamanhoMinimo = 2;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarTamanhoExatoSeNaoForNuloOuVazio(valor, tamanhoMinimo,
                "valor", "Nao tem tamanho minimo");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }


    }
}
