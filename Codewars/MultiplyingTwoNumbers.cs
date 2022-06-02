using System;
using System.Linq;

namespace Codewars
{
    public class MultiplyingTwoNumbers
    {
        //retorna a multiplicação de dois inteiros
        public static int Multiplier(int a, int b)
        {
            return a * b;

        }

        //retorna quantos papéis são necessários e inclui condicional 0;
        public static int Paperwork(int n, int m)
        {
            if (n < 0 || m < 0) return 0;
            return n * m;

        }

        //Soma números de um array
        public static double SumArray(double[] array)
        {
            double number = 0;

            for (int i = 0; i < array.Length; i++)
            {
                number += array[i];

            }
            return number;
        }
       
        //Retorna um array com contagem de positivos e soma de negativos
        public static int[] CountPositivesSumNegatives(int[] input)
        {         
            if (input == null || input.Length == 0)
            {
                return new int[] {}; // aqui deve retornar vazio
            }

            int countPositives = input.Count(i => i > 0);
            int sumNegatives = input.Where(i => i < 0).Sum();

            return new int[] { countPositives, sumNegatives };           
          
        }

        //Calcula IMC e retorna mensagem conforme tabela
        public static string Bmi(double weight, double height)
        {
            double bmi = weight / Math.Pow(height, 2);

            if (bmi <= 18.5) return "Underweight";
            if (bmi <= 25.0) return "Normal";
            if (bmi <= 30.0) return "Overweight";
            return "Obese";
           
            

        }
    }
}
