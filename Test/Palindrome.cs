using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Interfaces;
using TestDto;

namespace Test
{
    public class Palindrome: IPalindrome
    {
        public bool IsPalindrome(string text)
        {
            return text.SequenceEqual(text.Reverse());
        }

        public List<PalindromesDto> GetPalidromes(string inputString)
        {
            var subStrings =
                from i in Enumerable.Range(0, inputString.Length)
                from j in Enumerable.Range(0, inputString.Length - i + 1)
                where j >= 2
                select new PalindromesDto
                {
                    Text = inputString.Substring(i, j),
                    Index = i,
                    Length = inputString.Substring(i, j).Length,
                    IsPalindrome = IsPalindrome(inputString.Substring(i, j))
                };

            return RemoveContainedPalindromes(subStrings.Where(s => s.IsPalindrome).ToList());

        }

        List<PalindromesDto>RemoveContainedPalindromes(List<PalindromesDto> palindromes)
        {
            foreach (var shortPalindrome in palindromes.OrderBy(p => p.Length))
            {
                if (palindromes.Exists(r => r.Text.Contains(shortPalindrome.Text) && r.Length > shortPalindrome.Length))
                    palindromes.Remove(shortPalindrome);

            }
            return palindromes;
        }

        public List<PalindromesDto> GetTopPalidromes(string inputString, int number)
        {
            return GetPalidromes(inputString).OrderByDescending(p => p.Length).Take(3).ToList();
        }




    }
}
