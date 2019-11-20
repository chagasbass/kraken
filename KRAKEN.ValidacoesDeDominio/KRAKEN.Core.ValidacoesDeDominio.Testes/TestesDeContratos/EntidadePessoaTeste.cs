using KRAKEN.Core.ValidacoesDeDominio.Testes.EntidadesDeTeste;
using Xunit;

namespace KRAKEN.Core.ValidacoesDeDominio.Testes.TestesDeContratos
{
    public class EntidadePessoaTeste
    {
        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Entidade Pessoa")]
        [Fact(DisplayName = "DeveMostrarNotificacoesParaEntidadeInvalida")]
        public void DeveMostrarNotificacoesParaEntidadeInvalida()
        {
            var pessoa = new Pessoa("OIfdfdfdfdfdfdfd", 10);

            Assert.Equal(2,pessoa.Notificacoes.Count);
            Assert.False(pessoa.Valido);
        }

        [Xunit.TraitAttribute("Categoria", "Testes de Contrato de Entidade Pessoa")]
        [Fact(DisplayName = "NaoDeveMostrarNotificacoesParaEntidadeValida")]
        public void NaoDeveMostrarNotificacoesParaEntidadeValida()
        {
            var pessoa = new Pessoa("Thiago", 19);

            Assert.Equal(0, pessoa.Notificacoes.Count);
            Assert.True(pessoa.Valido);
        }
    }
}
