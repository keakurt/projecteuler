using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecteuler
{
    public class Problem1
    {
        /// <summary>
        /// Description : If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3,5,6 and 9. Them of these multiples is 23.
        /// Find the sum of all the multiples of firstNumber or secondNumber below maxValue.
        /// </summary>
        /// <param name="multiplesFirst"> First multiple number  </param>
        /// <param name="multiplesSecound"> Second multiple number </param>
        /// <param name="maxValue"> Max. Value </param>
        /// <returns>Sum of all the multiples</returns>
        public static string Solution(int multiplesFirst, int multiplesSecound, int maxValue)
        {
            IEnumerable<int> liste = Enumerable.Range(1, maxValue).Select(i => i % multiplesFirst == 0 || i % multiplesSecound == 0 ? i : 0);
            int sum = 0;
            foreach (int i in liste)
            {
                sum += i;
            }
            return  $"Problem 1 solution is : {sum.ToString()}";
        }

    }
}