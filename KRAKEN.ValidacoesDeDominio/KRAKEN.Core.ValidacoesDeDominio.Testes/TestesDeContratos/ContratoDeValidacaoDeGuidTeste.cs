
using KRAKEN.Core.ValidacoesDeDominio.Validacoes;
using System;
using Xunit;

namespace KRAKEN.Core.ValidacoesDeDominio.Testes.TestesDeContratos
{
    public class ContratoDeValidacaoDeGuidTeste
    {
        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Guid")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForemIguais")]
        public void DeveRetornarNotificacaoQuandoForemIguais()
        {
            var valor = Guid.NewGuid();
            var valorComparado = Guid.NewGuid();
            var segundoValorComparado = Guid.NewGuid();

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeSaoIguais(valor, valorComparado,
                "valor", "O valor não deve ser igual que o valor comparado");

            contrato.Requer()
              .VerificarSeSaoIguais(valor, segundoValorComparado,
              "valor", "O valor não deve ser igual que o valor comparado");

            Assert.False(contrato.Valido);
            Assert.Equal(2, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Guid")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForemIguais")]
        public void NaoDeveRetornarNotificacaoQuandoForemIguais()
        {
            var valor = Guid.NewGuid();
            var valorComparado = valor;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeSaoIguais(valor, valorComparado,
                "valor", "O valor deve ser igual que o valor comparado");
           
            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Guid")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoNaoForemIguais")]
        public void DeveRetornarNotificacaoQuandoNaoForemIguais()
        {
            var valor = Guid.NewGuid();
            var valorComparado = valor;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoSaoIguais(valor, valorComparado,
                "valor", "O valor não deve ser igual que o valor comparado");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Guid")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoNaoForemIguais")]
        public void NaoDeveRetornarNotificacaoQuandoNaoForemIguais()
        {
            var valor = Guid.NewGuid();
            var valorComparado = Guid.NewGuid();

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoSaoIguais(valor, valorComparado,
                "valor", "O valor deve ser igual que o valor comparado");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }


        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Guid")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoNaoEstiverVazio")]
        public void DeveRetornarNotificacaoQuandoNaoEstiverVazio()
        {
            var valor = Guid.NewGuid();

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEstaVazio(valor,
                "valor", "O valor  deve estar vazio");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Guid")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoNaoEstiverVazio")]
        public void NaoDeveRetornarNotificacaoQuandoNaoEstiverVazio()
        {
            var valor = Guid.Empty;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEstaVazio(valor,
                "valor", "O valor não deve estar vazio");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }


        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Guid")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoEstiverVazio")]
        public void DeveRetornarNotificacaoQuandoEstiverVazio()
        {
            var valor = Guid.Empty;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoEstaVazio(valor,
                "valor", "O valor  não deve estar vazio");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }


        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Guid")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoVerificarQueNaoEstaVazio")]
        public void NaoDeveRetornarNotificacaoQuandoVerificarQueNaoEstaVazio()
        {
            var valor = Guid.NewGuid();

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoEstaVazio(valor,
                "valor", "O valor  deve estar vazio");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

    }
}
