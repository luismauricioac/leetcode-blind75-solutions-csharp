using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace leetcode_blind75_solutions_csharp
{
    public class Solutions
    {
        private Solutions() { }
        public static bool IsPalindrome(String s)
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

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> prevMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (prevMap.ContainsKey(diff))
                {
                    return new int[] { prevMap[diff], i };
                }
                prevMap.Add(nums[i], i);

            }
            return new int[] { };
        }

        public static int LengthOfLongestSubstring(String s)
        {
            HashSet<char> charsSet = new HashSet<char>();
            int l = 0;
            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char aux = s[i];
                while (charsSet.Contains(aux))
                {
                    char rem = s[l];
                    charsSet.Remove(rem);
                    l += 1;
                }
                charsSet.Add(aux);
                res = Math.Max(res, (i - l + 1));
            }
            return res;
        }
    }
}
