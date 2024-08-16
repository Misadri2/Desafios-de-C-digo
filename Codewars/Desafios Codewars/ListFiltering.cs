using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars.Desafios
{
    public class ListFiltering
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();
        }

        public static IEnumerable<int> GetIntegersFromList2(List<object> listOfItems)
        {
            List<int> results = new List<int>();

            foreach (var item in listOfItems)
            {
                if (item is int)
                {
                    results.Add((int)item);
                }
            }

            return results;
        }
    }
}
