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
        public int eMailFinder(string textfrombox)
        {
            Regex format = new Regex(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = format.Matches(textfrombox);
            return matches.Count;
        }
    }
}
