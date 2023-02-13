using Assignment;
using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();

            Console.WriteLine("Enter Vehicle Details");
            Console.WriteLine("Enter Registration Number :");
            v1.Number = Console.ReadLine();
            Console.WriteLine("Enter Driver Name :");
            v1.Name = Console.ReadLine();
            Console.WriteLine("Enter Vehicle Type :");
            v1.Type = Console.ReadLine();
            Console.WriteLine("Enter Cost Per KM :");
            v1.Cost =float.Parse(Console.ReadLine());
            Console.WriteLine("Vehicle Details :");
            v1.Display();
        }
    }
}
