
using KRAKEN.Core.ValidacoesDeDominio.Testes.EntidadesDeTeste;
using KRAKEN.Core.ValidacoesDeDominio.Validacoes;
using System;
using Xunit;

namespace KRAKEN.Core.ValidacoesDeDominio.Testes.TestesDeContratos
{
    public class ContratoDeValidacaoDeObjetosTeste
    {
        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Objeto")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoNaoForNulo")]
        public void DeveRetornarNotificacaoQuandoNaoForNulo()
        {
            EntidadeDeTiposTeste entidade = new EntidadeDeTiposTeste();

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEstaNulo(entidade,
                "valor", "Nao deve ser nula");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Objeto")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForNulo")]
        public void NaoDeveRetornarNotificacaoQuandoForNulo()
        {
            EntidadeDeTiposTeste entidade = null;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEstaNulo(entidade,
                "valor", "Nao deve ser nula");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Objeto")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoNaoEstaNulo")]
        public void DeveRetornarNotificacaoQuandoNaoEstaNulo()
        {
            EntidadeDeTiposTeste entidade = null;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoEstaNulo(entidade,
                "valor", "Nao deve ser nula");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Objeto")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoSeNaoEstaNulo")]
        public void NaoDeveRetornarNotificacaoSeNaoEstaNulo()
        {
            EntidadeDeTiposTeste entidade = new EntidadeDeTiposTeste();

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoEstaNulo(entidade,
                "valor", "Nao deve ser nula");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }



        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Objeto")]
        [Fact(DisplayName = "DeveRetornarNotificacaoSeForemIguais")]
        public void DeveRetornarNotificacaoSeForemIguais()
        {
            EntidadeDeTiposTeste primeiraEntidade = new EntidadeDeTiposTeste();
            EntidadeDeTiposTeste segundaEntidade = new EntidadeDeTiposTeste();

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeSaoIguais(primeiraEntidade,segundaEntidade,
                "valor", "Nao deve ser nula");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Objeto")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoSeNaoForemIguais")]
        public void NaoDeveRetornarNotificacaoSeNaoForemIguais()
        {
            EntidadeDeTiposTeste primeiraEntidade = new EntidadeDeTiposTeste();
            EntidadeDeTiposTeste segundaEntidade = new EntidadeDeTiposTeste();
            segundaEntidade.GuidProp = Guid.NewGuid();
    
            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeSaoIguais(primeiraEntidade, segundaEntidade,
                "valor", "Nao deve ser nula");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }


        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Objeto")]
        [Fact(DisplayName = "DeveRetornarNotificacaoSeForemIguais")]
        public void DeveRetornarNotificacaoSeSaoIguais()
        {
            EntidadeDeTiposTeste entidade = new EntidadeDeTiposTeste();

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoSaoIguais(entidade, entidade,
                "valor", "Nao deve ser nula");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Objeto")]
        [Fact(DisplayName = "DeveRetornarNotificacaoSeNaoSaoIguais")]
        public void NaoDeveRetornarNotificacaoSeNaoSaoIguais()
        {
            EntidadeDeTiposTeste primeiraEntidade = new EntidadeDeTiposTeste();
            EntidadeDeTiposTeste segundaEntidade = new EntidadeDeTiposTeste();
            segundaEntidade.IntProp = 10;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoSaoIguais(primeiraEntidade, segundaEntidade,
                "valor", "Nao deve ser nula");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

    }
}
