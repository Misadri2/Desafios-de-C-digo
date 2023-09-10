using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars.LeetCode
{
    public class Soma_de_dois_números_em_uma_lista
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int primeiroNumero = 0; primeiroNumero < nums.Length - 1; primeiroNumero++)
                for (int segundoNumero = primeiroNumero + 1; segundoNumero < nums.Length; segundoNumero++)
                    if (nums[primeiroNumero] + nums[segundoNumero] == target)
                    {
                        return new int[] { primeiroNumero, segundoNumero };
                    }            
            return new int[] { };
        }
    }
}
