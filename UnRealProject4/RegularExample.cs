using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnRealProject4
{
    class RegularExample
    {
        // для проверки Regex формул используем сайт regex101.com

        public int eMailFinder(string textfrombox) // Ищем почтовые ящики
        {
            Regex format = new Regex(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = format.Matches(textfrombox);
            return matches.Count;
        }
        public int ipv4Finder(string textfrombox) // Ищем IPv4 адресса 
        {
            Regex format = new Regex(@"(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = format.Matches(textfrombox);
            return matches.Count;
        }
        public int ipv6Finder(string textfrombox) // Ищем IPv6 адресса 
        {
            Regex format = new Regex(@"\[(?:[a-zA-Z0-9]{0,4}:?){1,8}\]|\[(?:[a-zA-Z0-9]{0,4}:?){1,4}(?:[0-9]{1,3}\.){3}[0-9]{1,3}\]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = format.Matches(textfrombox);
            return matches.Count;
        }
        public int mobileFinder(string textfrombox) // Ищем номера мобильных телефонов
        {
            Regex format = new Regex(@"(\+\d{1,3}[- ]?)?\d{10}", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = format.Matches(textfrombox);
            return matches.Count;
        }
        public int engchar(string textfrombox) // Ищем английские буквы
        {
            Regex format = new Regex(@"[A-Za-z]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = format.Matches(textfrombox);
            return matches.Count;
        }
        public int numbers(string textfrombox) // Ищем цифры
        {
            Regex format = new Regex(@"[0-9]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = format.Matches(textfrombox);
            return matches.Count;
        }
    }
}
