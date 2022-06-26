using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars
{
   public class Countsheep
    {
        //Em um array de ovelhas/sheeps conta a quantidade de sheep/ovelha;
        public static int CountSheeps(bool[] sheeps)
        {
            int count = 0;                 // contador começando em zero
            foreach (bool sheep in sheeps) // bool de ovelha em array de ovelhas
            {
                if (sheep) count++;        // se for ovelha(true) conta 1
            }
            return count;                  // retorna a contagem

        }
    }
}
