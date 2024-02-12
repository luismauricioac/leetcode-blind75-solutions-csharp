using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace leetcode_blind75_solutions_csharp
{
    public class Solutions
    {
        public bool IsPalindrome(String s)
        {
            String strCleaned = Regex.Replace(s.ToLower(), "[^a-zA-Z0-9]", "");
            int last = strCleaned.Length - 1;
            for (int i = 0; i < strCleaned.Length; i++)
            {

                if (!(strCleaned[i] == strCleaned[last]))
                {
                    return false;
                }
                last -= 1;
            }
            return true;
        }
    }
}
