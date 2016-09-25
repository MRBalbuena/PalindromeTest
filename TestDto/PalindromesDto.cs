using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TestDto
{
    public class PalindromesDto
    {
        public string Text { get; set; }
        public int Index { get; set; }
        public int Length { get; set; }
        public bool IsPalindrome { get; set; }
    }
}
