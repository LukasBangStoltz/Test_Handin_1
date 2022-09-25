using ArabicToRoman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTS
{
    public class UnitTest2
    {
        [Fact]
        public void TestSucces()
        {
            Assert.Equal("IV", ArabicToRoman.ArabicToRoman.ArabicToRomanNumerals(4));
        }
        [Fact]
        public void TestFailArabic()
        {
            Assert.Equal("Ø", ArabicToRoman.ArabicToRoman.ArabicToRomanNumerals(2));
        }

        
    }
}
