using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication first number:");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication second number:");
            var second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Result: {first * second}");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
