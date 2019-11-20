namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    /// <summary>
    /// Validacoes para tipo Decimal
    /// </summary>
    public partial class Contrato
    {
        #region MaiorQue

        public Contrato VerificarSeMaiorQue(decimal valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(double valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor <= (double)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(float valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor <= (float)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(long valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor <= (float)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(int valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            if (propriedade is null)
                throw new System.ArgumentNullException(nameof(propriedade));

            return this;
        }

        #endregion MaiorQue

        #region MaiorOuIgualQue

        public Contrato VerificarSeMaiorOuIgualQue(decimal valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(double valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor < (double)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(float valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor < (float)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(long valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor < (float)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(int valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion VerificarSeMaiorOuIgualQue

        #region MenorQue

        public Contrato VerificarSeMenorQue(decimal valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(double valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor >= (double)comparador)
                InserirNotificacao(propriedade, mensagem);

            if (propriedade is null)
            {
                throw new System.ArgumentNullException(nameof(propriedade));
            }

            return this;
        }

        public Contrato VerificarSeMenorQue(float valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor >= (float)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(long valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor >= (float)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(int valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion VerificarSeMenorQue

        #region MenorOuIgualQue

        public Contrato VerificarSeMenorOuIgualQue(decimal valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(double valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor >= (double)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(float valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor >= (float)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(long valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor >= (float)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(int valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MenorOuIgualQue

        #region SaoIguais

        public Contrato VerificarSeSaoIguais(decimal valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(double valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor != (double)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(float valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor != (float)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(long valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor != (float)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(int valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion SaoIguais

        #region NaoSaoIguais

        public Contrato VerificarSeNaoSaoIguais(decimal valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(double valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor == (double)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(float valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor == (float)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(long valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor == (float)comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(int valor, decimal comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion NaoSaoIguais

        #region EstaEntre
        public Contrato VerificarSeEstaEntre(decimal valor, decimal de, decimal para, string propriedade, string mensagem)
        {
            if (!(valor >= de && valor <= para))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion EstaEntre

        public Contrato VerificarSeNuloOuNullable(decimal? valor, string propriedade, string mensagem)
        {
            if (valor == null || !valor.HasValue)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
    }
}
