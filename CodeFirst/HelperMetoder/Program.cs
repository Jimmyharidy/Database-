using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelperMetoder();
            ExtensionMetoder();
        }

        private static void ExtensionMetoder()
        {
            Console.WriteLine("Please enter a number:");
            string inputFloat = Console.ReadLine();
            float inputFloat2 = inputFloat.ConvertToFloat();
            Console.WriteLine(inputFloat2);
            Console.ReadLine();
        }

        private static void HelperMetoder()
        {
            Console.WriteLine("Please enter a number:");
            string inputText = Console.ReadLine();
            float inputTextEdited = ConvertingToFloat.ConvertStringToFloat(inputText);

            float calculationFloat = inputTextEdited * 12;
            Console.WriteLine(calculationFloat);
            Console.ReadLine();
        }
    }
}
