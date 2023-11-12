using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars.Desafios
{
    public class BreakingChocolate
    {

        public static int BreakChocolate(int n, int m)
        {
            return n * m > 0 ? n * m - 1 : 0;

            // Se n vezes m for maior que zero, multiplica n vezes m e subtrai 1, se não for retorna 0
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