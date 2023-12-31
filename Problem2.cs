using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace projecteuler
{
    public class Problem2
    {
        /// <summary>
        /// Description : Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2 , the first 10 terms will be: 1,2,3,5,8,13,21,34,55,89, ...
        /// By considering the terms in the Fibonacci sequence whose values do not exceed LİMİT, find the sum of the even/odd-valued terms.
        /// </summary>
        /// <param name="even"> Even-valued or Odd-valued  </param>
        /// <param name="limit"> Max. value of Fibonacci sequence </param>
        /// <returns>Sum of all the even/odd-valued terms</returns>
        public static string Solution(bool even, int limit)
        {
            int sum = 0, a = 1, b = 2;
            if (even)
            {
                while (b <= limit)
                {
                    sum += (b % 2 == 0) ? b : 0;
                    (a, b) = (b, a + b);
                }
            }
            else
            {
                while (b <= limit)
                {
                    sum += (b % 2 == 1) ? b : 0;
                    (a, b) = (b, a + b);
                }
            }
            string evenOdd = even ? "even" : "odd";
            return $"Sum of {evenOdd}-valued terms below {limit} in the Fibonacci sequence: {sum}";
        }

    }
}