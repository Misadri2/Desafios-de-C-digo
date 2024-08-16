using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Codewars.Desafios
{
    public class BreakingChocolate
    {

        //DESCRIPTION:
        //Your task is to split the chocolate bar of given dimension n x m into small squares.Each square is of size 1x1 and unbreakable.Implement a function that will return minimum number of breaks needed.
        //For example if you are given a chocolate bar of size 2 x 1 you can split it to single squares in just one break, but for size 3 x 1 you must do two breaks.
        //If input data is invalid you should return 0 (as in no breaks are needed if we do not have any chocolate to split). Input will always be a non-negative integer.

        public static int BreakChocolate(int n, int m)
        {
            return n * m > 0 ? n * m - 1 : 0;

            // Se n * m for maior que zero, multiplica n * m e subtrai 1, se não for retorna 0
        }

        public static void Greet(string name, int age)
        {
            Console.WriteLine($"Hello {name}, {age} how are you doing today?"); 

        }

        public static void Greet2(string name)
        {
            Console.WriteLine($"Hello {name}, how are you doing today?");
        }

        public static string Greet3(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }

        public static string Greet4(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }

    }
}