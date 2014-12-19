using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    public class StringUtilities
    {
        public string GetDuplicates(string s)
        {
            if (String.IsNullOrEmpty(s)) throw new ArgumentNullException("s");

            List<char> processed = new List<char>();
            StringBuilder dups = new StringBuilder();

            foreach (var chr in s.ToCharArray())
            {
                if (processed.Contains(chr))
                    dups.Append(chr.ToString());

                processed.Add(chr);
            }
            return dups.ToString();
        }
    }
}
