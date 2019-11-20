using global::KRAKEN.Core.ValidacoesDeDominio.Testes.EntidadesDeTeste;
using KRAKEN.Core.ValidacoesDeDominio.Validacoes;
using System;
using Xunit;

namespace KRAKEN.Core.ValidacoesDeDominio.Testes.TestesDeContratos
{
    public class ContratoDeValidacaoDeTimespanTeste
    {
        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Timespan")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForMaiorQue")]
        public void DeveRetornarNotificacaoQuandoForMaiorQue()
        {
            var entidadeTeste = new EntidadeDeTiposTeste();
            entidadeTeste.TimeSpanProp = new TimeSpan(0, 23, 54, 0);

            var timespanErro = new TimeSpan(0, 23, 54, 0).Add(TimeSpan.FromMilliseconds(10));

            var contrato = new Contrato()
                .Requer()
                .VerificarSeMaiorQue(entidadeTeste.TimeSpanProp, timespanErro, "timespan", "O valor deve ser maior que");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Timespan")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForMaiorQue")]
        public void NaoDeveRetornarNotificacaoQuandoForMaiorQue()
        {
            var entidadeTeste = new EntidadeDeTiposTeste();
            entidadeTeste.TimeSpanProp = new TimeSpan(0, 23, 54, 0).Add(TimeSpan.FromMilliseconds(10));

            var timespanErro = new TimeSpan(0, 23, 54, 0);

            var contrato = new Contrato()
                .Requer()
                .VerificarSeMaiorQue(entidadeTeste.TimeSpanProp, timespanErro, "timespan", "O valor deve ser maior que");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Timespan")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForMaiorOuIgualQue")]
        public void DeveRetornarNotificacaoQuandoForMaiorOuIgualQue()
        {
            var entidadeTeste = new EntidadeDeTiposTeste();
            entidadeTeste.TimeSpanProp = new TimeSpan(0, 23, 54, 0);

            var timespanErro = new TimeSpan(0, 23, 54, 0).Add(TimeSpan.FromMilliseconds(10));

            var contrato = new Contrato()
                .Requer()
                .VerificarSeMaiorOuIgualQue(entidadeTeste.TimeSpanProp, timespanErro, "timespan", "O valor deve ser maior que");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Timespan")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForMaiorOuIgualQue")]
        public void NaoDeveRetornarNotificacaoQuandoForMaiorOuIgualQue()
        {
            var entidadeTeste = new EntidadeDeTiposTeste();
            entidadeTeste.TimeSpanProp = new TimeSpan(0, 23, 54, 0).Add(TimeSpan.FromMilliseconds(10));

            var timespanErro = new TimeSpan(0, 23, 54, 0);

            var contrato = new Contrato()
                .Requer()
                .VerificarSeMaiorOuIgualQue(entidadeTeste.TimeSpanProp, timespanErro, "timespan", "O valor deve ser maior que");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Timespan")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForMenorQue")]
        public void DeveRetornarNotificacaoQuandoForMenorQue()
        {
            var entidadeTeste = new EntidadeDeTiposTeste();
            entidadeTeste.TimeSpanProp = new TimeSpan(0, 23, 54, 0).Add(TimeSpan.FromMilliseconds(10));

            var timespanErro = new TimeSpan(0, 23, 54, 0);

            var contrato = new Contrato()
                .Requer()
                .VerificarSeMenorQue(entidadeTeste.TimeSpanProp, timespanErro, "timespan", "O valor deve ser maior que");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Timespan")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoNaoForMaiorQue")]
        public void NaoDeveRetornarNotificacaoQuandoForMenorQue()
        {
            var entidadeTeste = new EntidadeDeTiposTeste();
            entidadeTeste.TimeSpanProp = new TimeSpan(0, 23, 54, 0);

            var timespanErro = new TimeSpan(0, 23, 54, 0).Add(TimeSpan.FromMilliseconds(10));

            var contrato = new Contrato()
                .Requer()
                .VerificarSeMenorQue(entidadeTeste.TimeSpanProp, timespanErro, "timespan", "O valor deve ser maior que");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Timespan")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForMenorOuIgualQue")]
        public void DeveRetornarNotificacaoQuandoForMenorOuIgualQue()
        {
            var entidadeTeste = new EntidadeDeTiposTeste();
            entidadeTeste.TimeSpanProp = new TimeSpan(0, 23, 54, 0).Add(TimeSpan.FromMilliseconds(10));

            var timespanErro = new TimeSpan(0, 23, 54, 0);

            var contrato = new Contrato()
                .Requer()
                .VerificarSeMenorOuIgualQue(entidadeTeste.TimeSpanProp, timespanErro, "timespan", "O valor deve ser maior que");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Timespan")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForMenorOuIgualQue")]
        public void NaoDeveRetornarNotificacaoQuandoForMenorOuIgualQue()
        {
            var entidadeTeste = new EntidadeDeTiposTeste();
            entidadeTeste.TimeSpanProp = new TimeSpan(0, 23, 54, 0);

            var timespanErro = new TimeSpan(0, 23, 54, 0).Add(TimeSpan.FromMilliseconds(10));

            var contrato = new Contrato()
                .Requer()
                .VerificarSeMenorOuIgualQue(entidadeTeste.TimeSpanProp, timespanErro, "timespan", "O valor deve ser maior que");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Timespan")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoEstiverEntre")]
        public void DeveRetornarNotificacaoQuandoEstiverEntre()
        {
            var entidadeTeste = new EntidadeDeTiposTeste();
            entidadeTeste.TimeSpanProp = new TimeSpan(0, 23, 53, 0).Add(TimeSpan.FromMilliseconds(10));

            var timespanInicio = new TimeSpan(0, 23, 54, 0);
            var timespanFim = new TimeSpan(0, 23, 55, 0);

            var contrato = new Contrato()
                .Requer()
                .VerificarSeEstaEntre(entidadeTeste.TimeSpanProp, timespanInicio,
                timespanFim, "timespan", "O valor deve estar entre");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Timespan")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoEstiverEntre")]
        public void NaoDeveRetornarNotificacaoQuandoEstiverEntre()
        {
            var entidadeTeste = new EntidadeDeTiposTeste();
            entidadeTeste.TimeSpanProp = new TimeSpan(0, 23, 54, 0).Add(TimeSpan.FromMilliseconds(10));

            var timespanInicio = new TimeSpan(0, 23, 54, 0);
            var timespanFim = new TimeSpan(0, 23, 55, 0);

            var contrato = new Contrato()
                .Requer()
                .VerificarSeEstaEntre(entidadeTeste.TimeSpanProp, timespanInicio,
                timespanFim, "timespan", "O valor deve estar entre");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }
    }
}
