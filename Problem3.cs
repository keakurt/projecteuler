using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace projecteuler
{
    public class Problem3
    {
        /// <summary>
        /// Description : The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number ?
        /// </summary>
        /// <param name="number"> The number whose largest prime factor is to be found  </param>
        /// <returns>Largest prime factor of number</returns>
        public static string Solution(string number)
        {
            BigInteger i;
            BigInteger bigNumber = BigInteger.Parse(number);
            for (i = 2; i <= bigNumber; i++)
            {
                if (bigNumber % i == 0)
                {
                    bigNumber /= i;
                    i--;
                }
            }

            return $"The largest prime factor of {number} is: {i}";
        }
    }
}