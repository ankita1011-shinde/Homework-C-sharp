using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class SimpleCalculator
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 2;

            Console.WriteLine("Addition is: "+(a+b));
            Console.WriteLine("Subtract is: " +(a-b));
            Console.WriteLine("Multiplication is: " +(a*b));
            Console.WriteLine("Division is: " + (a/b));
            Console.ReadLine();

        }
    }
}
