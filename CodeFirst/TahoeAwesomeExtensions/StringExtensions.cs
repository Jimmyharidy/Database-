using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahoeAwesomeExtensions
{
    public static class StringExtensions
    {
        public static string Dotify(this string originalString)  // This betyder att det kommer att bli en extension method.
        {
            return originalString + ".....Ext......";
        }
    }
}
