using System;

namespace KRAKEN.Core.ValidacoesDeDominio.Helpers
{
    public static class ValidacoesDeCep
    {
        public static string FormatarCep(string cep)
        {
            try
            {
                if (string.IsNullOrEmpty(cep))
                    return string.Empty;

                return Convert.ToUInt64(cep).ToString(@"00000\-000");
            }
            catch
            {
                return string.Empty;
            }
        }

        public static bool ValidarCep(string cep)
        {
            if (string.IsNullOrEmpty(cep))
                return false;

            if (cep.Length > 9)
                return false;

            if (cep.Length == 8)
                cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);
            
            return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
        }
    }
}
