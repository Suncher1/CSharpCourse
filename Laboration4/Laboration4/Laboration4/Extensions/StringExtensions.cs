using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4.Extensions
{
    public static class StringExtensions
    {
        //https://stackoverflow.com/questions/6724840/how-can-i-truncate-my-strings-with-a-if-they-are-too-long
        public static string Truncate(this string value, int maxChars)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }
    }
}
