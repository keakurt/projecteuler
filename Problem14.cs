using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace projecteuler
{
    public class Problem14
    {
        /// <summary>
        /// Description : The following iterative sequence is defined for the set of positive integers:
        /// n → n/2 (n is even)
        /// n → 3n + 1 (n is odd)
        /// Using the rule above and starting with 13, we generate the following sequence
        /// 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1.
        /// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
        /// Which starting number, under one million, produces the longest chain?
        /// NOTE: Once the chain starts the terms are allowed to go above one million.
        /// </summary>
        /// <returns>Longest Collatz Sequence</returns>
        public static int Solution(int limit)
        {
            List<int> chains = Enumerable.Range(1, limit).Select(i => GetChainLength(i)).ToList();

            return chains.IndexOf(chains.Max()) + 1;
        }
        static int GetChainLength(BigInteger number)
        {
            int chainLenght = 0;
            while (number > 1)
            {
                number = number % 2 == 0 ? number / 2 : (number * 3) + 1;
                chainLenght++;
            }
            return chainLenght + 1;
        }
    }
}