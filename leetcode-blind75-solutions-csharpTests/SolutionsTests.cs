using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode_blind75_solutions_csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_blind75_solutions_csharp.Tests
{
    [TestClass()]
    public class SolutionsTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            Assert.IsTrue(Solutions.IsPalindrome("amanaplanacanalpanama"));
        }

        [TestMethod()]
        public void TwoSum()
        {
            int[] expeted = new int[] { 0, 1 };
            int[] testResult = Solutions.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            CollectionAssert.AreEqual(expeted, testResult);
        }

        [TestMethod()]
        public void LengthOfLongestSubstring()
        {
            int expeted = 3;
            Assert.AreEqual(expeted, Solutions.LengthOfLongestSubstring("pwwkew"));
        }
    }
}