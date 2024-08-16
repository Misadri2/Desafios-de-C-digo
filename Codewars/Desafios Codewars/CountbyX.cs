using System;
using System.Linq;

namespace Codewars.Desafios
{
    public class CountbyX
    {
        //Criar uma função com dois argumentos que retornarão um array do primeiro número vezes o segundo número
        public static int[] CountBy(int x, int n)
        {
            var result = Enumerable.Range(1, n).Select(i => i * x).ToArray();
            return result;

        }

        //Should return the smalllest integer of the array
        public static int FindSmallestInt(int[] args)
        {
            return args.Min();
        }

        public static int FindSmallestInt2(int[] args)
        {
            int smallest = args[0];

            for (int i = 0; i < args.Length; i++)
            {
                for (int k = 0; k < args.Length; k++)
                {
                    if (smallest > args[k])
                    {
                        smallest = args[k];
                        break;
                    }
                }
            }
            return smallest;
        }

        //You can loop through the array elements with the for loop,
        //and use the Length property to specify how many times the loop should run.        
        public static void ArrayLoop(string[] cars)
        {
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

        }
    }
}
