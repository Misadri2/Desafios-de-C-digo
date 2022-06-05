using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    public  class RemovingElements
    {
        //Take an array and remove every second element from the array.
        //Always keep the first element and start removing with the next element.
        //Esse desafio particularmente não entendi a resolução
        public static object[] RemoveEveryOther(object[] arr)
        {
            var result= arr.Where((a, b) => b % 2 == 0).ToArray();
            return result;
        }
    }
}
