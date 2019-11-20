
using KRAKEN.Core.ValidacoesDeDominio.Testes.EntidadesDeTeste;
using KRAKEN.Core.ValidacoesDeDominio.Validacoes;
using Xunit;

namespace KRAKEN.Core.ValidacoesDeDominio.Testes.TestesDeContratos
{
    public  class ContratoDeValidacaoDeDoublesTeste
    {
        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForMaiorQue")]
        public void DeveRetornarNotificacaoQuandoForMaiorQue()
        {
            var valor = 0.42e2;
            var valorComparado = 50;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEMaiorQue(valor, valorComparado,
                "valor", "O valor deve ser maior que o valor comparado");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForMaiorQue")]
        public void NaoDeveRetornarNotificacaoQuandoForMaiorQue()
        {
            var valor = 3D;
            var valorComparado = 1400;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEMaiorQue(valor, valorComparado,
                "valor", "O valor não deve  ser maior que o valor comparado");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForMaiorOuIgualQue")]
        public void DeveRetornarNotificacaoQuandoForMaiorOuIgualQue()
        {
            var valor = 23;
            var valorComparado = 23;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEMaiorQue(valor, valorComparado,
                "valor", "O valor deve ser maior ou igual que o valor comparado");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForMaiorOuIgualQue")]
        public void NaoDeveRetornarNotificacaoQuandoForMaiorOuIgualQue()
        {
            var valor = 3D;
            var valorComparado = 1400;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEMaiorQue(valor, valorComparado,
                "valor", "O valor não deve ser maior ou igual que o valor comparado");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForMenorQue")]
        public void DeveRetornarNotificacaoQuandoForMenorQue()
        {
            var valor = 0.42e2;
            var valorComparado = 13;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEMenorQue(valor, valorComparado,
                "valor", "O valor deve ser menor que o valor comparado");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForMenorQue")]
        public void NaoDeveRetornarNotificacaoQuandoForMenorQue()
        {
            var valor = 0.42e2;
            var valorComparado = 10;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEMenorQue(valor, valorComparado,
                "valor", "O valor não deve ser menor que o valor comparado");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForMenorOuIgualQue")]
        public void DeveRetornarNotificacaoQuandoForMenorOuIgualQue()
        {
            var valor = 0.42e2;
            var valorComparado = 10;
            var segundoValorComparado = 19;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEMenorOuIgualQue(valor, valorComparado,
                "valor", "O valor deve ser menor que o valor comparado");

            contrato.Requer()
              .VerificarSeEMenorOuIgualQue(valor, segundoValorComparado,
              "valor", "O valor deve ser menor que o valor comparado");

            Assert.False(contrato.Valido);
            Assert.Equal(2, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForMenorOuIgualQue")]
        public void NaoDeveRetornarNotificacaoQuandoForMenorOuIgualQue()
        {
            var valor = 23;
            var valorComparado = 23;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEMenorOuIgualQue(valor, valorComparado,
                "valor", "O valor não deve ser menor que o valor comparado");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoForemDiferentes")]
        public void DeveRetornarNotificacaoQuandoForemDiferentes()
        {
            var valor = 3D;
            var valorComparado = 22;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeSaoIguais(valor, valorComparado,
                "valor", "O valores  devem ser iguais");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForemIguais")]
        public void NaoDeveRetornarNotificacaoQuandoForemIguais()
        {
            var valor = 23;
            var valorComparado = 23;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeSaoIguais(valor, valorComparado,
                "valor", "O valores  devem ser iguais");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoForemIguais")]
        public void DeveRetornarNotificacaoQuandoForemIguais()
        {
            var valor = 23;
            var valorComparado = 23;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoSaoIguais(valor, valorComparado,
                "valor", "O valores  não devem ser iguais");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoNaoForemIguais")]
        public void NaoDeveRetornarNotificacaoQuandoNaoForemIguais()
        {
            var valor = 23;
            var valorComparado = 22;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeNaoSaoIguais(valor, valorComparado,
                "valor", "O valores  devem ser iguais");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "DeveRetornarNotificacaoQuandoNaoEstiverEntre")]
        public void DeveRetornarNotificacaoQuandoNaoEstiverEntre()
        {
            var valor = 21;
            var PrimeiroValorComparado = 22;
            var segundoValorComparado = 25;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEstaEntre(valor, PrimeiroValorComparado, segundoValorComparado,
                "valor", "O valor deve estar entre os valores ");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "NaoDeveRetornarNotificacaoQuandoEstiverEntre")]
        public void NaoDeveRetornarNotificacaoQuandoEstiverEntre()
        {
            var valor = 23;
            var PrimeiroValorComparado = 22;
            var segundoValorComparado = 25;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEstaEntre(valor, PrimeiroValorComparado, segundoValorComparado,
                "valor", "O valor não deve estar entre os valores ");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "DeveRetornarNotificaoQuandoValorForNuloOuNullable")]
        public void DeveRetornarNotificaoQuandoValorForNuloOuNullable()
        {
            var entidadeTeste = new EntidadeDeTiposTeste();
            entidadeTeste.NullableDoubleProp = null;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEstaNulo(entidadeTeste.NullableDoubleProp,
                "valor", "O valor não deve ser nulo ");

            Assert.True(contrato.Valido);
            Assert.Equal(0, contrato.Notificacoes.Count);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Double")]
        [Fact(DisplayName = "NaoDeveRetornarNotificaoQuandoValorNaoForNuloOuNullable")]
        public void NaoDeveRetornarNotificaoQuandoValorNaoForNuloOuNullable()
        {
            var entidadeTeste = new EntidadeDeTiposTeste();
            entidadeTeste.NullableDoubleProp = 3D;

            var contrato = new Contrato();

            contrato.Requer()
                .VerificarSeEstaNulo(entidadeTeste.NullableDoubleProp,
                "valor", "O valor  deve ser nulo ");

            Assert.False(contrato.Valido);
            Assert.Equal(1, contrato.Notificacoes.Count);
        }
    }
}
