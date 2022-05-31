using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    public static class ExIList
    {
        public static void TreinamentoIList()
        {
            var tagsList = new List<string>
            {
              "CORE",
              "AZURE",
              "EFCORE",
              "SCYLLADB",
              "ASPNETCORE",
            };
            //Efetuando uma consulta:            

         

            var tags2 = tagsList.Where(t => t.Length >= 8).ToList();
            tagsList[0] = "SQLSERVER";

            foreach (var tag2 in tags2)
            {
                Console.WriteLine(tag2);
            }

            Console.WriteLine("************************");

            var tags = tagsList.Where(t => t.Length >= 8);
            tagsList[0] = "SQLSERVER";

            foreach (var tag in tags)
            {
                Console.WriteLine(tag);
            }
        }
    }
}
