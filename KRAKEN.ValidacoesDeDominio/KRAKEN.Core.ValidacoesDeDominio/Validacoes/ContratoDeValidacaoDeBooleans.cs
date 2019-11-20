namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    /// <summary>
    /// Contrato para tipos booleanos
    /// </summary>
    public partial class Contrato
    {
        public Contrato VerificarSeFalso(bool valor, string propriedade, string mensagem)
        {
            if (valor)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeVerdadeiro(bool valor, string propriedade, string mensagem) =>
            VerificarSeFalso(!valor, propriedade, mensagem);
    }
}