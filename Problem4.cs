using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{

    public class Problem4
    {

        /// <summary>
        /// Description : A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 X 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        /// <param name="digit"> How many digits of palindrome number do you want?  </param>
        /// <returns>The largest palindrome number</returns>
        public static string Solution(int digit)
        {
            int largestPalindrome = 0;
            int maxDigit = int.Parse(new string('9', digit));
            int minDigit = int.Parse('1' + new string('0', digit - 1));

            for (int i = maxDigit; i >= minDigit; i--)
            {
                if (i * maxDigit < largestPalindrome)
                {
                    break;
                }

                for (int j = i; j >= minDigit; j--)
                {
                    int product = i * j;

                    if (product <= largestPalindrome)
                    {
                        break;
                    }

                    if (IsPalindrome(product))
                    {
                        largestPalindrome = product;
                    }
                }
            }

            return $"The largest palindrome made from the product of {digit}-digit numbers is : {largestPalindrome}";
        }

        private static bool IsPalindrome(int number)
        {
            string numberStr = number.ToString();

            for (int i = 0; i < numberStr.Length / 2; i++)
            {
                if (numberStr[i] != numberStr[numberStr.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}