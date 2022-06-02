using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    public class ExDiversos
    {

        //Retorna se o número é par ou ímpar
        public static string EvenOrOdd(int number)
        {
            if(number%2!=0)
                return "Odd";
            else return "Even";
        }

        //Soma números de um array
        public static double SumArray(double[] array)
        {            
            double number = 0;

            for(int i = 0; i < array.Length; i++)
            {
                number += array[i];
               
            }
            return number;
        }

        //Outra forma de somar números de um array
        public static double SumArray2(double[] array)
        {
            return array.Sum();
        }

        //Multiplicar o valor de um nome onde cada caractere custa 30,00, sem usar o operador *
        //não pode usar o sinal *
        public static double Billboard(string name, double price = 30)
        {           
            double soma = 0;           
            
            for(int i = 1; i <= name.Length; i++)
            {
                soma += price;
            }
            return soma;
           
        }

        //retira os espaços da string
        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");

            //Outras possibilidades:
            //return input.Trim(); Tira os espaços do fim e do começo
            //return input.TrimEnd(); Tira os espaços do fim 
            //return input.TrimStart(); Tira os espaços do começo
        }
    }
}
