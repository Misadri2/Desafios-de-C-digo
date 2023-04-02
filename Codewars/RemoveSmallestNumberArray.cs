using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    public class RemoveSmallestNumberArray
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers.Count > 0)
            {
                numbers.Remove(numbers.Min());
            }
            return numbers;

        }
    }
}
