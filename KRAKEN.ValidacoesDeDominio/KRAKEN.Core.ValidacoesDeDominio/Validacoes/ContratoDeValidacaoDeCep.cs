using KRAKEN.Core.ValidacoesDeDominio.Helpers;

namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    public partial class Contrato
    {
        public Contrato VerificarSeCepValido(string cep,string propriedade ,string mensagem)
        {
            if (!ValidacoesDeCep.ValidarCep(cep))
                InserirNotificacao(propriedade, mensagem);
            
            return this;
        }

        public Contrato VerificarSeCepVazio(string cep,string propriedade,string mensagem)
        {
            if(string.IsNullOrEmpty(cep))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarTamanho(string valor, string propriedade, string mensagem)
        {
            const int tamanhoCepComMascara = 9;
            
            //24130-110
            if (string.IsNullOrEmpty(valor) || valor.Length != tamanhoCepComMascara)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
    }
}
