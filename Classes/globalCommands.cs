using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNoTetris.Classes
{
    public class globalCommands
    {
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


    }
}
