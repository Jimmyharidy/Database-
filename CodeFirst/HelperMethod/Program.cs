using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TahoeAwesomeExtensions;

namespace HelperMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write some text:");
            string inputText = Console.ReadLine();
            string inputTextEdited = inputText.Dotify();

            Console.WriteLine();
            Console.WriteLine("input text edited:" + inputTextEdited);
            Console.WriteLine("...........");
            Console.ReadLine();
        }
    }
}
