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
            List<char> dups = new List<char>();
            StringBuilder sb = new StringBuilder();

            foreach (var chr in s.ToCharArray())
            {
                if (processed.Contains(chr))
                {
                    if (!dups.Contains(chr))
                    {
                        dups.Add(chr);
                        sb.Append(chr);
                    }
                }
                else
                {
                    processed.Add(chr);
                }
            }
            return sb.ToString();
        }
    }
}
