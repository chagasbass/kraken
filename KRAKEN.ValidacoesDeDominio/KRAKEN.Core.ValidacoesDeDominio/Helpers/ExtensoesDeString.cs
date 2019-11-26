using System.Linq;

namespace KRAKEN.Core.ValidacoesDeDominio.Helpers
{
    public static class ExtensoesDeString
    {
        public static bool TodosOsCaracteresSaoIguais(this string valor)
        {
            return valor.Length == 0 || valor.All(ch => ch == valor[0]);
        }
    }
}