using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecteuler
{
    public class Problem7
    {
        /// <summary>
        /// Description : By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        /// What is the 10001st prime number?
        /// </summary>
        /// <param name="findNthPrime "> End of range  </param>
        /// <returns>Find Nth Prime</returns>
        public static int Solution(int findNthPrime)
        {
            if (findNthPrime == 1) return 2;

            int count = 1;
            int candidate = 3;

            while (count < findNthPrime)
            {
                if (IsPrime(candidate)) count++;
                if (count < findNthPrime) candidate += 2;
            }

            return candidate;
        }
        private static bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i * i <= number; i++)
                if (number % i == 0) return false;

            return true;
        }
    }
}