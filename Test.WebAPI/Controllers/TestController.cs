using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestDto;

namespace Test.WebAPI.Controllers
{
    public class TestController : ApiController
    {
        public List<PalindromesDto> GetPalindromes(string value)
        {
            var palindromes = new Palindrome();
            return palindromes.GetTopPalidromes(value, 3);
        }
    }
}
