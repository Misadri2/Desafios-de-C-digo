using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars
{
    public class ANeedleintheHaystack
    {
        public static string FindNeedle()
        {
            object[] haystack = {"needle1", "needle2","needle" };
            return "found the needle at position " + Array.IndexOf(haystack, "needle");
           
        }
    }

}
