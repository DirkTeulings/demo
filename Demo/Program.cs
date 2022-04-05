using Demo.Model;
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
            var user = new User();
            var address = new Address();
            
            Console.WriteLine("What is your name?");
            user.name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            user.age = Console.ReadLine();
            
            Console.WriteLine("What street do you live?");
            address.street = Console.ReadLine();
            Console.WriteLine("What is your house number?");
            address.number = Console.ReadLine();

            user.address = address;
            Console.WriteLine($"Hi {user.GetDisplayText()}");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
