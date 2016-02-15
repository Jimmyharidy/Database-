using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HelperMetoder
{
    public static class ConvertingToFloat
    {
        public static float ConvertStringToFloat(string text )
        {
            float stringFloat = float.Parse(text);

            return stringFloat;
        }
       
    }
    
}
