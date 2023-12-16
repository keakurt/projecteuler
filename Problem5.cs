using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecteuler
{
    public class Problem5
    {
        /// <summary>
        /// Description : 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        /// What is the smallest positive number that is evenly divisible divisible with no remainder by all of the numbers from startNumber to endNumber
        /// </summary>
        /// <param name="startNumber"> First value of range  </param>
        /// <param name="endNumber"> Last value of range  </param>
        /// <returns>The smallest multiple</returns>
        public static string Solution(int startNumber, int endNumber)
        {
            return $"{Enumerable.Range(startNumber, endNumber).Aggregate(LeastCommonDivisor)}";
        }

        private static int LeastCommonDivisor(int startNumber, int endNumber)
        {
            return (startNumber == 0) || (endNumber == 0) ? 0 : (startNumber / GreatestCommonDivisor(startNumber, endNumber)) * endNumber;
        }
        private static int GreatestCommonDivisor(int startNumber, int endNumber)
        {
            return (endNumber == 0) ? startNumber : GreatestCommonDivisor(endNumber, startNumber % endNumber);
        }

    }
}