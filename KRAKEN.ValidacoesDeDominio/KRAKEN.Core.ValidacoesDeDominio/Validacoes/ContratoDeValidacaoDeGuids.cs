using System;

namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    /// <summary>
    /// Contrato de Validação de GUID
    /// </summary>
    public partial class Contrato
    {
        public Contrato VerificarSeSaoIguais(Guid valor, Guid comparador, string propriedade, string mensagem)
        {
            if (!string.Equals(valor.ToString(),comparador.ToString(), StringComparison.Ordinal))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(Guid valor, Guid comparador, string propriedade, string mensagem)
        {
            if (string.Equals(valor.ToString(),comparador.ToString(),StringComparison.Ordinal))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEstaVazio(Guid valor, string propriedade, string mensagem)
        {
            if (valor != Guid.Empty)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoEstaVazio(Guid valor, string propriedade, string mensagem)
        {
            if (valor == Guid.Empty)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
    }
}
