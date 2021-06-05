using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Extensions
{
    public static class StringExtensions
    {
       public static string GetReverse(this string name)
        {
            
            string result = string.Empty;
            for (int i = name.Length-1; i >= 0; i--)
            {
                result += name[i];
            }
            
            return result;
        }

        
    }
}
