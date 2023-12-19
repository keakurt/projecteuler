using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace projecteuler
{
    public class Problem10
    {
        /// <summary>
        /// Description : The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17. 
        /// Find the sum of all the primes below input.
        /// </summary>
        /// <param name="limit"> </param>
        /// <returns>Summation of Primes/returns>
        public static string Solution(int limit)
        {
            // We will use the Sieve of Eratosthenes algorithm for the solution. https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes


            bool[] isPrime = new bool[limit + 1];

            for (int i = 2; i <= limit; i++)
            {
                isPrime[i] = true; // We assume that all numbers are prime
            }

            for (int i = 2; i * i <= limit; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= limit; j += i) //We mark all multiples of the entire sequence, starting from 2, as non-prime
                    {
                        isPrime[j] = false;
                    }
                }
            }

            BigInteger sum = Enumerable.Range(2, limit - 1)
                                  .Where(i => isPrime[i])
                                  .Aggregate(BigInteger.Zero, (acc, i) => acc + i);

            return $"{sum}";
        }
    }
}