using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace projecteuler
{
    public class Problem6
    {
        /// <summary>
        /// Description : The sum of the squares of the first ten natural numbers is, 1^2 + 2^2 + ... + 10^2 = 385
        /// The square of the sum of the first ten natural numbers is (1 + 2 + ... + 10)^2 = 55^2 = 3025.
        /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// </summary>
        /// <param name="limit"> End of range  </param>
        /// <returns>Sum Square Difference</returns>
        public static string Solution(int limit)
        {
            return $"{SquareOfSum(limit) - SumOfSquare(limit)}";
        }

        private static BigInteger SquareOfSum(int limit)
        {
            BigInteger sum = limit * (limit + 1) / 2;
            return sum * sum;

        }
        private static BigInteger SumOfSquare(int limit)
        {
            List<BigInteger> result = Enumerable.Range(1, limit).Select(i => new BigInteger(i * i)).ToList();
            BigInteger sum = 0;
            foreach (var item in result)
            {
                sum += item;
            }
            return sum;
        }
    }
}