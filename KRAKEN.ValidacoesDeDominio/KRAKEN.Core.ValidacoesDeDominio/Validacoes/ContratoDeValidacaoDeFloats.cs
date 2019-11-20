namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    public partial class Contrato
    {
        #region MaiorQue

        public Contrato VerificarSeMaiorQue(decimal valor, float comparador, string propriedade, string mensagem)
        {
            if ((double)valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(double valor, float comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(float valor, float comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(long valor, float comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(int valor, float comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MaiorQue

        #region MaiorOuIgualQue

        public Contrato VerificarSeMaiorIgualQue(decimal valor, float comparador, string propriedade, string mensagem)
        {
            if ((double)valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorIgualQue(double valor, float comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorIgualQue(float valor, float comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorIgualQue(long valor, float comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorIgualQue(int valor, float comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MaiorIgualQue

        #region MenorQue

        public Contrato VerificarSeMenorQue(decimal valor, float comparador, string propriedade, string mensagem)
        {
            if ((double)valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(double valor, float comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(float valor, float comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(long valor, float comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(int valor, float comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MenorQue

        #region MenorOuIgualQue

        public Contrato VerificarSeMenorOuIgualQue(decimal valor, float comparador, string propriedade, string mensagem)
        {
            if ((double)valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(double valor, float comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(float valor, float comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(long valor, float comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(int valor, float comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MenorOuIgualQue

        #region SaoIguais

        public Contrato VerificarSeSaoIguais(decimal valor, float comparador, string propriedade, string mensagem)
        {
            if ((double)valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(double valor, float comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(float valor, float comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(long valor, float comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(int valor, float comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion SaoIguais

        #region NaoSaoIguais

        public Contrato VerificarSeNaoSaoIguais(decimal valor, float comparador, string propriedade, string mensagem)
        {
            if ((double)valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(double valor, float comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(float valor, float comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(long valor, float comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(int valor, float comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion NaoSaoIguais

        #region EstaEntre

        public Contrato VerificarSeEstaEntre(float valor, float from, float to, string propriedade, string mensagem)
        {
            if (!(valor >= from && valor <= to))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion Between

        public Contrato VerificarSeNulaOuTipoNullable(float? valor, string propriedade, string mensagem)
        {
            if (valor == null || !valor.HasValue)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
    }
}
