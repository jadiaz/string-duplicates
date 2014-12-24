using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Dictionary<char, int> processed = new Dictionary<char, int>();
            StringBuilder sb = new StringBuilder();

            char[] arr = s.ToCharArray();

            foreach (char c in arr)
            {
                if (processed.ContainsKey(c))
                {
                    processed[c] = processed[c] + 1;
                    if (processed[c] == 2)
                    {
                        sb.Append(c);
                    }
                }
                else
                {
                    processed.Add(c, 1);
                }
            }

            return sb.ToString();
        }
    }
}
