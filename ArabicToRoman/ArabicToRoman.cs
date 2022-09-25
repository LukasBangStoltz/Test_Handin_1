using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabicToRoman
{
    public static class ArabicToRoman

    {
        public static void Main() {

            Console.WriteLine("Type your arabic number: ");
            
            int arabNumber = Convert.ToInt32( Console.ReadLine());

            string result = ArabicToRomanNumerals(arabNumber);
            Console.WriteLine("Converted number: " + result);

        }

       public static string ArabicToRomanNumerals(int arabicNum)
        {
            if (arabicNum == 0)
            {
                return "";
            }
            var dict = new Dictionary<int, string>()
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"},
            };

            var romanBuilder = new StringBuilder();

            foreach (KeyValuePair<int, string> entry in dict)
            {
                while (arabicNum >= entry.Key)
                {
                    arabicNum -= entry.Key;
                    romanBuilder.Append(entry.Value);
                }
            }
            return romanBuilder.ToString();
        }
    }
}
