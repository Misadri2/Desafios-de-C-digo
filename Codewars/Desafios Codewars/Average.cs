using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars.Desafios
{
    public class Average
    {

        public static char GetGrade(int s1, int s2, int s3)
        {
            int score = (s1 + s2 + s3) / 3;

            if (score >= 90) return 'A';
            if (score >= 80) return 'B';
            if (score >= 70) return 'C';
            if (score >= 60) return 'D';
            return 'F';
        }


        public static string Saudação(string name, string owner)
        {
            if (name == owner) return "Hello boss";
            return "Hello guest";
        }

        //Outra maneira interessante de resolver o mesmo desafio 
        public static string SaudaçãoGreet(string name, string owner)
        {
            return name == owner ? "Hello boss" : "Hello guest";
        }
    }
}
