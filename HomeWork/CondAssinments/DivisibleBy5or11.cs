using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.CondAssinments
{
    internal class DivisibleBy5or11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any num");
            int n= Convert.ToInt32(Console.ReadLine());

            if (n % 5 == 0)
                {
                Console.WriteLine("Divisible by 5");
                }
            else if(n % 11 == 0)
            {
                Console.WriteLine("Divisible by 11");

            }
            else
                Console.WriteLine("Not Divisible by Both");
        }
    }
}
