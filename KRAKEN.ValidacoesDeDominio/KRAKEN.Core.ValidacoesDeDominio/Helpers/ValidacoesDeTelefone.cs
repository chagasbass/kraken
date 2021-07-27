using System;
using System.Collections.Generic;
using System.Linq;

namespace KRAKEN.Core.ValidacoesDeDominio.Helpers
{
    public static class ValidacoesDeTelefone
    {
        private static IEnumerable<int> DDDsValidos = new List<int>() {
    11,12,13,14,15,16,17,18,19,21,22,24,27,28,31,32,33,
    34,35,37,38,41,42,43,44,45,46,47,48,49,51,53,54,55,
    61,62,63,64,65,66,67,68,69,71,73,74,75,77,79,81,82,
    83,84,85,86,87,88,89,91,92,93,94,95,96,97,98,99};

        public static bool ValidarDDD(string telefone)
        {
            if (telefone.Any(x => !char.IsLetter(x)))
                return false;

            var ddd = telefone.Replace("(", "").Replace(")", "");
            var digitosDoDDD = Int32.Parse(ddd.Substring(0, 2));

            if (DDDsValidos.FirstOrDefault(x => x == digitosDoDDD) > 0)
                return true;

            return false;
        }
    }
}