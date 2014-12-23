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

            List<char> dups = new List<char>();
            StringBuilder sb = new StringBuilder();

            char[] arr1 = s.ToCharArray();
            char[] arr2 = s.ToCharArray();

            for (int i = 0; i < 20; i++)
            {

                Stopwatch sw = Stopwatch.StartNew();
                for (int c2 = 0; c2 < arr2.Length; c2++)
                {
                    if (!dups.Contains(arr2[c2]))
                    {
                        for (int c1 = 0; c1 < arr1.Length; c1++)
                        {
                            if (arr2[c2] == arr1[c1])
                            {
                                dups.Add(arr2[c2]);
                                sb.Append(arr2[c2]);
                                break;
                            }
                        }
                    }
                }
                sw.Stop();
                Debug.WriteLine("elapsed time {0}ms", sw.Elapsed);
            }
            return sb.ToString();
        }
    }
}
