using KRAKEN.Core.ValidacoesDeDominio.Helpers;

namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    public partial class Contrato
    {
        public Contrato VerificarSeTelefoneCelularComDDDEValido(string telefoneCelular, string propriedade, string mensagem)
        {
            string padrao = @"(\(([^)]*)\))(\s?)(([0-9]{0,5})(\-)?([0-9]{0,4}))$";
            VerificarPadrao(telefoneCelular, padrao, propriedade, mensagem);

            VerificarSeDDDEValido(telefoneCelular, propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeTelefoneFixoComDDDEValido(string telefoneFixo,string propriedade,string mensagem)
        {
            string padrao = @"(\(([^)]*)\))(\s?)(([0-8]{0,5})(\-)?([0-9]{0,4}))$";

            VerificarPadrao(telefoneFixo, padrao, propriedade, mensagem);

            VerificarSeDDDEValido(telefoneFixo, propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeDDDEValido(string telefone,string propriedade,string mensagem)
        {
            if (!ValidacoesDeTelefone.ValidarDDD(telefone))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
    }
}
