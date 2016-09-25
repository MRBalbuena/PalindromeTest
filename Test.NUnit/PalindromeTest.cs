using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestDto;


namespace Test.NUnit
{
    [TestFixture]
    public class PalindromeTest
    {
        const string PalidromeString = "abcba";
        const string NonPolidromeString = "abcabc";
        const string LongPolidromeString = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopabcba";
        const int TopNumber = 3;

        [Test]
        public void IsPalindrome()
        {
            var palindrome = new Palindrome();
            Assert.IsFalse(palindrome.IsPalindrome(NonPolidromeString));
            Assert.IsTrue(palindrome.IsPalindrome(PalidromeString));                                   
        }

        [Test]
        public void GetTopPalindrome_GetTop()
        {            
            var palindrome = new Palindrome();
            var palidromes = palindrome.GetTopPalidromes(LongPolidromeString, TopNumber);

            Assert.IsTrue(palidromes.Count == TopNumber);
            for (int i = 0; i < palidromes.Count; i++)
            {
                if(i < palidromes.Count - 1)
                    Assert.IsTrue(palidromes[i].Length >= palidromes[i+1].Length);
            }
        }

    }
}
