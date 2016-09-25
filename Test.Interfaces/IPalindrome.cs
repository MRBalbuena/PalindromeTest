using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDto;

namespace Test.Interfaces
{
    public interface IPalindrome
    {
        bool IsPalindrome(string text);
        List<PalindromesDto> GetPalidromes(string inputString);
        List<PalindromesDto> GetTopPalidromes(string inputString, int number);
    }
}
