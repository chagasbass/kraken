namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    /// <summary>
    /// Contrato para validação de Tipos Long
    /// </summary>
    public partial class Contrato
    {
        #region MaiorQue

        public Contrato VerificarSeMaiorQue(decimal valor, long comparador, string propriedade, string mensagem)
        {
            if ((double)valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(double valor, long comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(float valor, long comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(int valor, long comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorQue(long valor, long comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MaiorQue

        #region MaiorOuIgualQue

        public Contrato VerificarSeMaiorOuIgualQue(decimal valor, long comparador, string propriedade, string mensagem)
        {
            if ((double)valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(double valor, long comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(float valor, long comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(int valor, long comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMaiorOuIgualQue(long valor, long comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MaiorOuIgualQue

        #region MenorQue

        public Contrato VerificarSeMenorQue(decimal valor, long comparador, string propriedade, string mensagem)
        {
            if ((double)valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(double valor, long comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(float valor, long comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(int valor, long comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorQue(long valor, long comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MenorQue

        #region MenorOuIgualQue

        public Contrato VerificarSeMenorOuIgualQue(decimal valor, long comparador, string propriedade, string mensagem)
        {
            if ((double)valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(double valor, long comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(float valor, long comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(int valor, long comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeMenorOuIgualQue(long valor, long comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion MenorOuIgualQue

        #region SaoIguais

        public Contrato VerificarSeSaoIguais(decimal valor, long comparador, string propriedade, string mensagem)
        {
            if ((double)valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(double valor, long comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(float valor, long comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(int valor, long comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(long valor, long comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion SaoIguais

        #region NaoSaoIguais

        public Contrato VerificarSeNaoSaoIguais(decimal valor, long comparador, string propriedade, string mensagem)
        {
            if ((double)valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(double valor, long comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(float valor, long comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(int valor, long comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(long valor, long comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion NaoSaoIguais

        #region EstaEntre

        public Contrato VerificarSeEstaEntre(long valor, long de, long para, string propriedade, string mensagem)
        {
            if (!(valor >= de && valor <= para))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        #endregion EstaEntre

        public Contrato VerificarSeNuloOuNullable(long? valor, string propriedade, string mensagem)
        {
            if (valor == null || !valor.HasValue)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
    }
}
