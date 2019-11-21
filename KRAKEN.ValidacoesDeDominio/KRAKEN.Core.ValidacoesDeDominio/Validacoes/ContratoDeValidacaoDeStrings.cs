using System;
using System.Text.RegularExpressions;

namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    /// <summary>
    /// Contrato de validação para tipo string
    /// </summary>
    public partial class Contrato
    {
        public Contrato VerificarSeNaoNuloOuVazio(string valor, string propriedade, string mensagem)
        {
            if (string.IsNullOrEmpty(valor))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoNuloOuEspacoEmBranco(string valor, string propriedade, string mensagem)
        {
            if (string.IsNullOrWhiteSpace(valor))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNuloOuVazio(string valor, string propriedade, string mensagem)
        {
            if (!string.IsNullOrEmpty(valor))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeTemTamanhoMinimo(string valor, int minimo, string propriedade, string mensagem)
        {
            if (string.IsNullOrEmpty(valor) || valor.Length < minimo)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeTemTamanhoMaximo(string valor, int maximo, string propriedade, string mensagem)
        {
            if (string.IsNullOrEmpty(valor) || valor.Length > maximo)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarTamanho(string valor, int tamanho, string propriedade, string mensagem)
        {
            if (string.IsNullOrEmpty(valor) || valor.Length != tamanho)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeContem(string valor, string texto, string propriedade, string mensagem)
        {
            var stringComparison = StringComparison.CurrentCultureIgnoreCase;
            if (valor.IndexOf(texto, stringComparison) >= 0)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeSaoIguais(string valor, string text, string propriedade, string mensagem, StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            if (!valor.Equals(text, comparisonType))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeNaoSaoIguais(string valor, string text, string propriedade, string mensagem, StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            if (valor.Equals(text, comparisonType))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeEmailValido(string email, string propriedade, string mensagem)
        {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return VerificarPadrao(email, pattern, propriedade, mensagem);
        }

        public Contrato VerificarSeEmailInvalidoOuVazio(string email, string propriedade, string mensagem)
        {
            if (!string.IsNullOrEmpty(email))
                return VerificarSeEmailValido(email, propriedade, mensagem);

            InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeUrl(string url, string propriedade, string mensagem)
        {
            const string pattern = @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";
            return VerificarPadrao(url, pattern, propriedade, mensagem);
        }

        public Contrato VerificarSeUrlOuVazio(string url, string propriedade, string mensagem)
        {
            if (string.IsNullOrEmpty(url))
                return this;

            return VerificarSeUrl(url, propriedade, mensagem);
        }

        public Contrato VerificarPadrao(string texto, string pattern, string propriedade, string mensagem)
        {
            if (!Regex.IsMatch(texto ?? "", pattern))
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarSeDigito(string texto, string propriedade, string mensagem)
        {
            const string pattern = @"^\d+$";
            return VerificarPadrao(texto, pattern, propriedade, mensagem);
        }

        public Contrato VerificarTamanhoMinimoSeNaoForNuloOuVazio(string texto, int minimo, string propriedade, string mensagem)
        {
            if (!string.IsNullOrEmpty(texto) && texto.Length < minimo)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarTamanhoMaximoSeNaoForNuloOuVazio(string texto, int maximo, string propriedade, string mensagem)
        {
            if (!string.IsNullOrEmpty(texto) && texto.Length > maximo)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }

        public Contrato VerificarTamanhoExatoSeNaoForNuloOuVazio(string texto, int tamanho, string propriedade, string mensagem)
        {
            if (!string.IsNullOrEmpty(texto) && texto.Length != tamanho)
                InserirNotificacao(propriedade, mensagem);

            return this;
        }
    }
}
