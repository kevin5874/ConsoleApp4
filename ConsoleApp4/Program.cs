using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            HourlyPay Person1 = new HourlyPay(Int32.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()));
            Console.WriteLine("Person 2");
            HourlyPay Person2 = new HourlyPay(Int32.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()));
            Console.WriteLine("Annual salary of Person 1: {0}" , Person1.GetTotalPay());
            Console.WriteLine("Annual salary of Person 2: {0}", Person2.GetTotalPay());
            bool compare = Person1.GetTotalPay() > Person2.GetTotalPay();
            Console.WriteLine("Does Person 1 make more money than person 2: {0}", compare);
            Console.ReadKey();
           
        }
    }
}
