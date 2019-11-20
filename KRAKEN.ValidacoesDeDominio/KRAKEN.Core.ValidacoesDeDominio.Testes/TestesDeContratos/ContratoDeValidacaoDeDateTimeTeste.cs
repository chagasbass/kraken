using KRAKEN.Core.ValidacoesDeDominio.Testes.EntidadesDeTeste;
using KRAKEN.Core.ValidacoesDeDominio.Validacoes;

using System;
using Xunit;

namespace KRAKEN.Core.ValidacoesDeDominio.Testes.TestesDeContratos
{
    public class ContratoDeValidacaoDeDateTimeTeste
    {
        [TraitAttribute("Categoria", "Testes de Contrato de DateTime")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoDataForMaiorQue")]
        public void DeveRetornarNotificacaoQuandoDataForMaiorQue()
        {
            var entidade = new EntidadeDeTiposTeste();
            entidade.DateTimeProp = DateTime.Now;

            var dataParaTeste = DateTime.Now.AddDays(10);

            var contrato = new Contrato();

            contrato
                .Requer()
                .VerificarSeMaiorQue(entidade.DateTimeProp, dataParaTeste,
                    "datetime", "a data da entidade deve ser maior que a data para teste");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de DateTime")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoDataNaoForMaiorQue")]
        public void NaoDeveRetornarNotificacaoQuandoDataNaoForMaiorQue()
        {
            var entidade = new EntidadeDeTiposTeste();
            entidade.DateTimeProp = DateTime.Now;

            var dataParaTeste = DateTime.Now.AddDays(-2);

            var contrato = new Contrato();

            contrato
                .Requer()
                .VerificarSeMaiorQue(entidade.DateTimeProp, dataParaTeste,
                    "datetime", "a data da entidade deve ser maior que a data para teste");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de DateTime")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoDataForMaiorOuIgualQue")]
        public void DeveRetornarNotificacaoQuandoDataForMaiorOuIgualQue()
        {
            var entidade = new EntidadeDeTiposTeste();
            entidade.DateTimeProp = DateTime.Now;

            var dataParaTeste = DateTime.Now;

            var contrato = new Contrato();

            contrato
                .Requer()
                .VerificarSeMaiorIgualQue(entidade.DateTimeProp, dataParaTeste,
                    "datetime", "a data da entidade não deve ser maoir ou igual que a data para teste");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de DateTime")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoDataNaoForMaiorOuIgualQue")]
        public void NaoDeveRetornarNotificacaoQuandoDataNaoForMaiorOuIgualQue()
        {
            var entidade = new EntidadeDeTiposTeste();
            entidade.DateTimeProp = DateTime.Now;

            var dataParaTeste = DateTime.Now.AddDays(-2);

            var contrato = new Contrato();

            contrato
                .Requer()
                .VerificarSeMaiorIgualQue(entidade.DateTimeProp, dataParaTeste,
                    "datetime", "a data da entidade  deve ser maoir ou igual que a data para teste");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de DateTime")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoDataForMenorQue")]
        public void DeveRetornarNotificacaoQuandoDataForMenorQue()
        {
            var entidade = new EntidadeDeTiposTeste();
            entidade.DateTimeProp = DateTime.Now;

            var dataParaTeste = DateTime.Now.AddDays(2);

            var contrato = new Contrato();

            contrato
                .Requer()
                .VerificarSeMaiorQue(entidade.DateTimeProp, dataParaTeste,
                    "datetime", "a data da entidade deve ser menor que a data para teste");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de DateTime")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoDataNaoForMenorQue")]
        public void NaoDeveRetornarNotificacaoQuandoDataNaoForMenorQue()
        {
            var entidade = new EntidadeDeTiposTeste();
            entidade.DateTimeProp = DateTime.Now;

            var dataParaTeste = DateTime.Now.AddDays(-2);

            var contrato = new Contrato();

            contrato
                .Requer()
                .VerificarSeMaiorQue(entidade.DateTimeProp, dataParaTeste,
                    "datetime", "a data da entidade não deve ser menor que a data para teste");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de DateTime")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoDataForMenorOuIgualQue")]
        public void DeveRetornarNotificacaoQuandoDataForMenorOuIgualQue()
        {
            var entidade = new EntidadeDeTiposTeste();
            entidade.DateTimeProp = DateTime.Now;

            var dataParaTeste = DateTime.Now.AddDays(2);

            var contrato = new Contrato();

            contrato
                .Requer()
                .VerificarSeMaiorQue(entidade.DateTimeProp, dataParaTeste,
                    "datetime", "a data da entidade deve ser menor ou igual que a data para teste");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de DateTime")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoDataNaoForMenorOuIgualQue")]
        public void NaoDeveRetornarNotificacaoQuandoDataNaoForMenorOuIgualQue()
        {
            var entidade = new EntidadeDeTiposTeste();
            entidade.DateTimeProp = DateTime.Now;

            var dataParaTeste = DateTime.Now.AddDays(-2);

            var contrato = new Contrato();

            contrato
                .Requer()
                .VerificarSeMaiorQue(entidade.DateTimeProp, dataParaTeste,
                    "datetime", "a data da entidade não deve ser menor que a data para teste");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de DateTime")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoDataEstiverEntreIntervalo")]
        public void DeveRetornarNotificacaoQuandoDataEstiverEntreIntervalo()
        {
            var entidade = new EntidadeDeTiposTeste();
            entidade.DateTimeProp = DateTime.Now.AddDays(10);

            var dataInicioIntervalo = DateTime.Now.AddDays(-2);

            var datFimIntervalo = DateTime.Now.AddDays(2);

            var contrato = new Contrato();

            contrato
                .Requer()
                .VerificarSeEstaEntre(entidade.DateTimeProp, dataInicioIntervalo, datFimIntervalo,
                    "datetime", "a data da entidade deve estar entre intervalo proposto");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de DateTime")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoDataEstiverEntreIntervalo")]
        public void NaoDeveRetornarNotificacaoQuandoDataEstiverEntreIntervalo()
        {
            var entidade = new EntidadeDeTiposTeste();
            entidade.DateTimeProp = DateTime.Now;

            var dataInicioIntervalo = DateTime.Now.AddDays(-2);

            var datFimIntervalo = DateTime.Now.AddDays(2);

            var contrato = new Contrato();

            contrato
                .Requer()
                .VerificarSeEstaEntre(entidade.DateTimeProp, dataInicioIntervalo, datFimIntervalo,
                    "datetime", "a data da entidade não deve estar entre intervalo proposto");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de DateTime")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoDataForNulaOuNullable")]
        public void DeveRetornarNotificacaoQuandoDataForNulaOuNullable()
        {
            var entidade = new EntidadeDeTiposTeste();
            entidade.NullableDateTimeProp = null;

            var contrato = new Contrato();

            contrato
                .Requer()
                .VerificarSeNulaOuTipoNullable(entidade.NullableDateTimeProp,
                    "datetime", "a data deve ser nula ou nullable");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [TraitAttribute("Categoria", "Testes de Contrato de DateTime")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoDataEstiverEntreIntervalo")]
        public void NaoDeveRetornarNotificacaoQuandoDataForNulaOuNullable()
        {
            var entidade = new EntidadeDeTiposTeste();
            entidade.NullableDateTimeProp = DateTime.Now.AddDays(10);

            var contrato = new Contrato();

            contrato
               .Requer()
               .VerificarSeNulaOuTipoNullable(entidade.NullableDateTimeProp,
                   "datetime", "a data deve ser nula ou nullable");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }
    }
}
