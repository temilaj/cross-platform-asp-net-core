using System;

namespace cross_platform_asp_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");            
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, we just ran a .NET core application on a mac. Whoop!");
        }
    }
}
