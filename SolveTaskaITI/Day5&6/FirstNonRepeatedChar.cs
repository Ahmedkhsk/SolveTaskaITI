using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day5_6
{
    public static class FirstNonRepeatedChar
    {
        public static int FindFirstNonRepeatedChar(string s)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (freq[s[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}
