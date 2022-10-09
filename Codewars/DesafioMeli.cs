using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    //Desafio Meli foi mais complicado, mas isso foi o que consegui entregar.
    public class DesafioMeli
    {
        public static void SomadeDigitos(int numero)
        {
            
            //Pode ser feito pedindo ao usuário ou declarando na chamada do método
            // int numero;
            //Console.WriteLine("Infome o número: ");
            //numero = Convert.ToInt32(Console.ReadLine());
            int digito;
            int soma = 0;

            while (numero > 0)
            {
                digito = numero % 10;
                soma = soma + digito;
                numero = numero / 10;
            }
            if (soma == 21)
            {
                Console.WriteLine($"Soma = {soma}");
            }
            else
            {
                Console.WriteLine("Valor diferente de 21");
            }
            Console.ReadKey();
        }
        
    }
}
