namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    /// <summary>
    /// Contrado para validação de objetos
    /// </summary>
    public partial class Contrato
    {
        public Contrato VerificarSeEstaNulo(object objeto, string propriedade, string mensagem)
        {
            if (objeto != null)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoEstaNulo(object objeto, string propriedade, string mensagem)
        {
            if (objeto == null)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(object objeto, object comparador, string propriedade, string mensagem)
        {
            if (!objeto.Equals(comparador))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(object objeto, object comparador, string propriedade, string mensagem)
        {
            if (objeto.Equals(comparador))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
    }
}
