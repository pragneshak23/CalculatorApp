using System;
using Calculator;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Function.Add(40, 10));
            Console.WriteLine(Function.Sub(40, 10));
            Console.WriteLine(Function.Multi(40, 10));
            Console.WriteLine(Function.Sub(40, 10));

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
