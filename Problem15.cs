using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecteuler
{
    /// <summary>
    /// Description : Starting in the top left corner of a 2x2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
    /// How many such routes are there through a 20x20 grid?
    /// </summary>
    /// <param name="gridSize"> Size of grid. ex: 20x20  </param>
    /// <returns>Lattice Paths</returns>
    public class Problem15
    {
        public static long Solution(int gridSize)
        {
            long[,] paths = new long[gridSize + 1, gridSize + 1];

            paths[0, 0] = 1;

            for (int i = 0; i <= gridSize; i++)
            {
                for (int j = 0; j <= gridSize; j++)
                {
                    if (i > 0) paths[i, j] += paths[i - 1, j];
                    if (j > 0) paths[i, j] += paths[i, j - 1];
                }
            }

            return paths[gridSize, gridSize];
        }
    }
}