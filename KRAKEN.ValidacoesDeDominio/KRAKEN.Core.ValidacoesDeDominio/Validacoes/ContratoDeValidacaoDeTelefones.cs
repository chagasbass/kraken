using KRAKEN.Core.ValidacoesDeDominio.Helpers;
using System.Collections.Generic;

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

        public Contrato VerificarSeTelefoneCelularSemDDDEValido(string telefoneCelular,string propriedade,string mensagem)
        {
            VerificarSeExisteLetra(telefoneCelular, propriedade, mensagem);

            if (!telefoneCelular.StartsWith("9"))
            {
                InserirNotificacao(propriedade, mensagem);
            }

            if(telefoneCelular.Length != 9)
            {
                InserirNotificacao(propriedade, mensagem);
            }

            var numerosErroneos = new List<string>() { "000000000","111111111","222222222","333333333","444444444",
            "555555555","666666666","777777777","888888888"};

            if (telefoneCelular.TodosOsCaracteresSaoIguais() && numerosErroneos.Contains(telefoneCelular))
            {
                InserirNotificacao(propriedade, mensagem);
            }

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
