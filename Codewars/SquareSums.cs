using System;
using System.Linq;

namespace Codewars
{
    public class SquareSums
    {

        public static int SquareSum(int[] n)
        {
            return (int)n.Sum(i => Math.Pow(i, 2));
        }
    }

}
