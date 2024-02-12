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
            Solutions solutions = new Solutions();
            Assert.IsTrue(solutions.IsPalindrome("amanaplanacanalpanama"));
        }
    }
}