using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMetoder
{
   public static class StringExtensions
    {
       public static float ConvertToFloat(this string text)
       {
            float stringFloat = float.Parse(text);

            return stringFloat;
        }
    }
}
