using System.Collections.Generic;
using System.Linq;

namespace KRAKEN.Core.ValidacoesDeDominio
{
    /// <summary>
    /// Classe que contém as rotinas para inserção de notificações
    /// </summary>
    public abstract class Notificavel:INotificavel
    {
        private readonly List<Notificacao> _notificacoes;

        protected Notificavel() => _notificacoes = new List<Notificacao>();

        public IReadOnlyCollection<Notificacao> Notificacoes => _notificacoes;

        public void InserirNotificacao(string propriedade, string mensagem) => _notificacoes.Add(new Notificacao(propriedade, mensagem));

        public void InserirNotificacao(Notificacao notificacao) => _notificacoes.Add(notificacao);

        public void InserirNotificacoes(IReadOnlyCollection<Notificacao> notificacoes) => _notificacoes.AddRange(notificacoes);

        public void InserirNotificacoes(IList<Notificacao> notificacoes) => _notificacoes.AddRange(notificacoes);

        public void InserirNotificacoes(ICollection<Notificacao> notificacoes) => _notificacoes.AddRange(notificacoes);

        public void InserirNotificacoes(Notificavel item) => InserirNotificacoes(item.Notificacoes);
       
        public void InserirNotificacoes(params Notificavel[] items)
        {
            foreach (var item in items)
                InserirNotificacoes(item);
        }

        public void RemoverNotificacoes() => _notificacoes.Clear();

        public abstract void Validar();
        

        public bool Invalido => _notificacoes.Any();
        public bool Valido => !Invalido;
    }
}
