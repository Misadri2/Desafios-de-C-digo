using System.Linq;

namespace Codewars
{
    public class CountbyX
    {
        //Criar uma função com dois argumentos que retornarão um array do primeiro número vezes o segundo número
        public static int[] CountBy(int x, int n)
        {    
            var result = Enumerable.Range(1, n).Select(i => i * x).ToArray();           
            return result;
           
        }
    }
}
