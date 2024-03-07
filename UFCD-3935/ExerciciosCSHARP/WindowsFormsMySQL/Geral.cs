using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsMySQL
{
    internal class Geral
    {
        public static string TirarEspacos(string texto)
        {
            texto = texto.Trim();
            texto = Regex.Replace(texto, @"\s+", " "); //tb pode ser (texto, "\\s+", " ");
            return texto;
        }

        public static bool CheckDate(string data)
        {
            try
            {
                DateTime dt = DateTime.Parse(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
