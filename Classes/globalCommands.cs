using System;

namespace MyNoTetris.Classes
{
    public class globalCommands
    {
        /* Auxiliares que eu uso de uma blibioteca pessoal */
        public string[] Split(string value, string separator)
        {
            string[] stringSeparators = { separator };

            string[] resultado = value.Split(stringSeparators, System.StringSplitOptions.None);
            return resultado;
        }

        public string EdData(string wlDate)
        {
            if (string.IsNullOrWhiteSpace(wlDate))
                return string.Empty;
            if (wlDate.Length < 8)
                return "";
            try
            {
                // Return Right(wlDate, 2) & "/" & wlDate.Substring(4, 2) & "/" & wlDate.Substring(0, 4)
                return wlDate.Substring(6, 2) + "/" + wlDate.Substring(4, 2) + "/" + wlDate.Substring(0, 4);
            }
            catch
            {
                return "";
            }
        }

        public string Format(DateTime data, string formato)
        {
            return data.ToString(formato);
        }
    }
}