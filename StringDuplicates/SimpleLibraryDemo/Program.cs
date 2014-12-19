using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLibrary;

namespace SimpleLibraryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Library Demonstration Application");
            Console.WriteLine("Please enter a string:");

            string input = Console.ReadLine();

            try
            {
                StringUtilities stringUtils = new StringUtilities();
                Console.WriteLine(stringUtils.GetDuplicates(input));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
