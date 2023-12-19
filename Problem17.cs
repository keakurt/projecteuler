using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecteuler
{
    public class Problem17
    {
        /// <summary>
        /// Description : If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
        /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
        /// NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
        /// </summary>
        /// <param name="start"> First value of range  </param> 
        /// <param name="end"> Last value of range  </param> 
        /// <returns>Number Letter Counts</returns>
        public static int Solution(int start, int end)
        {
            int totalLetters = 0;
            for (int i = start; i <= end; i++)
            {
                string numberInWords = ConvertNumberToWords(i);
                totalLetters += CountLetters(numberInWords);
            }
            return totalLetters;
        }

        private static string ConvertNumberToWords(int number)
        {
            if (number == 1000)
            {
                return "one thousand";
            }

            string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string words = "";

            if (number / 100 > 0)
            {
                words += units[number / 100] + " hundred";
                if (number % 100 > 0)
                {
                    words += " and ";
                }
            }

            if (number % 100 < 20)
            {
                words += units[number % 100];
            }
            else
            {
                words += tens[(number % 100) / 10];
                if (number % 10 > 0)
                {
                    words += " " + units[number % 10];
                }
            }

            return words;
        }

        private static int CountLetters(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}