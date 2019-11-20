using System;

namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    /// <summary>
    /// Contrato de Validação para Tipo TimeSpan
    /// </summary>
    public partial class Contrato
    {
        public Contrato VerificarSeMaiorQue(TimeSpan valor, TimeSpan comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(TimeSpan valor, TimeSpan comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(TimeSpan valor, TimeSpan comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(TimeSpan valor, TimeSpan comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEstaEntre(TimeSpan valor, TimeSpan de, TimeSpan para, string propriedade, string mensagem)
        {
            if (!(valor >= de && valor <= para))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
    }
}
