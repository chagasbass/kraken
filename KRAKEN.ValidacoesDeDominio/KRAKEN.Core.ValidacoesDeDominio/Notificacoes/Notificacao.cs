namespace KRAKEN.Core.ValidacoesDeDominio
{
    /// <summary>
    /// Classe que representa uma notificação.
    /// Contém uma propriedade (nome da propriedade na qual o erro aconteceu)
    /// e uma mensagem (descrição do erro).
    /// </summary>
    public sealed class Notificacao
    {
        public string Propriedade { get; private set; }
        public string Mensagem { get; private set; }

        public Notificacao(string propriedade, string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }
    }
}