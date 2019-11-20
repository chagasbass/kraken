using System;

namespace  KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    /// <summary>
    /// Classe de contrato para Tipos Data
    /// </summary>
    public partial class Contrato
    {
        public Contrato VerificarSeMaiorQue(DateTime valor, DateTime comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorIgualQue(DateTime valor, DateTime comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(DateTime valor, DateTime comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(DateTime valor, DateTime comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEstaEntre(DateTime valor, DateTime de, DateTime para, string propriedade, string mensagem)
        {
            if (!(valor >= de && valor <= para))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNulaOuTipoNullable(DateTime? valor, string propriedade, string mensagem)
        {
            if (valor == null || !valor.HasValue)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
    }
}