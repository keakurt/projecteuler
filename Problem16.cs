using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace projecteuler
{
    public class Problem16
    {
        /// <summary>
        /// Description : 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26 .
        /// What is the sum of the digits of the number 2^1000 ?
        /// </summary>
        /// <param name="x"> Base  </param> 
        /// <param name="n"> Power  </param> 
        /// <returns>Power Digit Sum</returns>
        public static BigInteger Solution(BigInteger x, int n)
        {
            // https://en.wikipedia.org/wiki/Exponentiation_by_squaring

            return PowerDigit(x, n).ToString().Select(i => BigInteger.Parse(i.ToString())).Aggregate(BigInteger.Add);
        }
        private static BigInteger PowerDigit(BigInteger x, int n)
        {
            BigInteger result = n == 0 ? 1 : n % 2 == 0 ? PowerDigit(x * x, n / 2) : x * PowerDigit(x * x, (n - 1) / 2);

            return result;
        }
    }
}
