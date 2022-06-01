using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.CondAssinments
{
    internal class PositiveNegZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a=Convert.ToInt32(Console.ReadLine());

            if(a>0)
            {
                Console.WriteLine("Num is positive");
            }
            else if(a<0)
            {
                Console.WriteLine("Num is negative");
            }
            else
                Console.WriteLine("Zero");
        }
    }
}
