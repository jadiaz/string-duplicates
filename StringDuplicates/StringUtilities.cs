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
                    processed[c] = processed[c] + 1;
                else
                    processed.Add(c, 1);
            }

            foreach (var character in processed)
            {
                if (character.Value > 1)
                    sb.Append(character.Key);
            }
            return sb.ToString();
        }
    }
}
