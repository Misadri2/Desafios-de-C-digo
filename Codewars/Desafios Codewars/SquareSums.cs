using System;
using System.Linq;

namespace Codewars.Desafios
{
    public class SquareSums
    {

        public static int SquareSum(int[] n)
        {
            return (int)n.Sum(i => Math.Pow(i, 2));
        }

        

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(i => i).Take(2).Sum();
        }

        //OrderBy https://learn.microsoft.com/pt-br/dotnet/api/system.linq.enumerable.orderby?view=net-7.0
        //Take https://learn.microsoft.com/pt-br/dotnet/api/system.linq.enumerable.take?view=net-7.0
    }

}
