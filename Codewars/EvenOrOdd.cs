using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    public class ExEvenOrOdd
    {
        public static string EvenOrOdd(int number)
        {
            if(number%2!=0)
                return "Odd";
            else return "Even";
        }

        public static double SumArray(double[] array)
        {            
            double number = 0;

            for(int i = 0; i < array.Length; i++)
            {
                number += array[i];
               
            }
            return number;
        }

        public static double SumArray2(double[] array)
        {
            return array.Sum();
        }

        public static double Billboard(string name, double price = 30)
        {
            return name.Length * (price);
           
        }
    }
}
