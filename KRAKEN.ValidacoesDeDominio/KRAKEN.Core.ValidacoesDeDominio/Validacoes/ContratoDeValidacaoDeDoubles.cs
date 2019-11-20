namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    /// <summary>
    /// Validacoes de tipo double
    /// </summary>
    public partial class Contrato
    {
        #region MaiorQue

        public Contrato VerificarSeMaiorQue(decimal valor, double comparador, string propriedade, string mensagem)
        {
            if ((double)valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(double valor, double comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(float valor, double comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(long valor, double comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(int valor, double comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MaiorQue

        #region MaiorOuIgualQue

        public Contrato VerificarSeMaiorOuIgualQue(decimal valor, double comparador, string propriedade, string mensagem)
        {
            if ((double)valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(double valor, double comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(float valor, double comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(long valor, double comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(int valor, double comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MaiorOuIgualQue

        #region MenorQue

        public Contrato VerificarSeMenorQue(decimal valor, double comparador, string propriedade, string mensagem)
        {
            if ((double)valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(double valor, double comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(float valor, double comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(long valor, double comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(int valor, double comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MenorQue

        #region MenorOuIgualQue

        public Contrato VerificarSeMenorOuIgualQue(decimal valor, double comparador, string propriedade, string mensagem)
        {
            if ((double)valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(double valor, double comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(float valor, double comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(long valor, double comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(int valor, double comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MenorOuIgualQue

        #region SaoIguais

        public Contrato VerificarSeSaoIguais(decimal valor, double comparador, string propriedade, string mensagem)
        {
            if ((double)valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(double valor, double comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(float valor, double comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(long valor, double comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(int valor, double comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion SaoIguais

        #region SeNaoSaoIguais

        public Contrato VerificarSeSeNaoSaoIguais(decimal valor, double comparador, string propriedade, string mensagem)
        {
            if ((double)valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSeNaoSaoIguais(double valor, double comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSeNaoSaoIguais(float valor, double comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSeNaoSaoIguais(long valor, double comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSeNaoSaoIguais(int valor, double comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion SeNaoSaoIguais

        #region EstaEntre

        public Contrato VerificarSeEstaEntre(double valor, double de, double para, string propriedade, string mensagem)
        {
            if (!(valor >= de && valor <= para))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion EstaEntre

        public Contrato VerificarSeNuloOuNullable(double? valor, string propriedade, string mensagem)
        {
            if (valor == null || !valor.HasValue)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
    }
}
