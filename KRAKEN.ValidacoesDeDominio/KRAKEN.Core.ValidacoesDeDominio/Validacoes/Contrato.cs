using System;
using System.Linq.Expressions;

namespace KRAKEN.Core.ValidacoesDeDominio.Validacoes
{
    /// <summary>
    /// Classe que representa o contrato para as notificações por tipos
    /// </summary>
    public partial class Contrato : Notificavel
    {
        public Contrato Requer()
        {
            return this;
        }

        public Contrato Juntar(params Notificavel[] items)
        {
            if (items != null)
            {
                foreach (var notificavel in items)
                {
                    if (notificavel.Invalido)
                        InserirNotificacoes(notificavel.Notificacoes);
                }
            }

            return this;
        }
        public Contrato SeNaoForNull(object tipoParametro, Expression<Func<Contrato, Contrato>> expressaoDeContrato)
        {
            if (tipoParametro != null)
            {
                expressaoDeContrato.Compile().Invoke(this);
            }

            return this;
        }

        public override void Validar()
        {
            throw new NotImplementedException("Deve implementar este método");
        }
    }
}
