namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    /// <summary>
    /// Contrato de Validação de tipo inteiro
    /// </summary>
    public partial class Contrato
    {
        #region EMaiorQue
        public Contrato VerificarSeEMaiorQue(decimal valor, int comparador, string propriedade, string mensagem)
        {
            if ((double)valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMaiorQue(double valor, int comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMaiorQue(float valor, int comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMaiorQue(long valor, int comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMaiorQue(int valor, int comparador, string propriedade, string mensagem)
        {
            if (valor <= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
        #endregion

        #region EMaiorQueOuIgual
        public Contrato VerificarSeEMaiorQueOuIgual(decimal valor, int comparador, string propriedade, string mensagem)
        {
            if ((double)valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMaiorQueOuIgual(double valor, int comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMaiorQueOuIgual(float valor, int comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMaiorQueOuIgual(long valor, int comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMaiorQueOuIgual(int valor, int comparador, string propriedade, string mensagem)
        {
            if (valor < comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
        #endregion

        #region EMenorQue
        public Contrato VerificarSeEMenorQue(decimal valor, int comparador, string propriedade, string mensagem)
        {
            if ((double)valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMenorQue(double valor, int comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMenorQue(float valor, int comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMenorQue(long valor, int comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMenorQue(int valor, int comparador, string propriedade, string mensagem)
        {
            if (valor >= comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
        #endregion

        #region EMenorOuIgualQue
        public Contrato VerificarSeEMenorOuIgualQue(decimal valor, int comparador, string propriedade, string mensagem)
        {
            if ((double)valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMenorOuIgualQue(double valor, int comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMenorOuIgualQue(float valor, int comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMenorOuIgualQue(long valor, int comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEMenorOuIgualQue(int valor, int comparador, string propriedade, string mensagem)
        {
            if (valor > comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
        #endregion

        #region SaoIguais
        public Contrato VerificarSeSaoIguais(decimal valor, int comparador, string propriedade, string mensagem)
        {
            if ((double)valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(double valor, int comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(float valor, int comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(long valor, int comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(int valor, int comparador, string propriedade, string mensagem)
        {
            if (valor != comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
        #endregion

        #region NaoSaoIguais
        public Contrato VerificarSeNaoSaoIguais(decimal valor, int comparador, string propriedade, string mensagem)
        {
            if ((double)valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(double valor, int comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(float valor, int comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(long valor, int comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(int valor, int comparador, string propriedade, string mensagem)
        {
            if (valor == comparador)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
        #endregion

        #region EstaEntre      
        public Contrato VerificarSeEstaEntre(int valor, int from, int to, string propriedade, string mensagem)
        {
            if (!(valor >= from && valor <= to))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
        #endregion

        public Contrato VerificarSeNulaOuTipoNullable(int? valor, string propriedade, string mensagem)
        {
            if (valor == null || !valor.HasValue)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
    }
}
