using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecteuler
{
    public class Problem9
    {
        /// <summary>
        /// Description : A Pythagorean triplet is a set of three natural numbers, a < b < c for which, a^2 + b^2 = c^2.
        /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2
        /// There exists exactly one Pythagorean triplet for which a + b + c =.1000,
        /// Find the product abc.
        /// </summary>
        /// <returns>Special Pythagorean Triplet</returns>
        public static int Solution()
        {
            /*
            a + b + c = 1000
            a^2 + b^2 = c^2 =>
            a^2+b^2 = a^2 + 2ab + 2000a + b^2 - 2000b + 1000000, after simplifying;
            1000a + 1000b - ab = 500000. So we have obtained the equality that we need to find and code
            */

            bool found = false;
            int a = 0, b = 0;
            for (a = 0; a < 500; a++)
            {
                for (b = 0; b < 500; b++)
                {
                    if (1000 * a + 1000 * b - a * b == 500000)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            return a * b * (1000 - (a + b));// c = 1000 - a + b
        }
    }
}