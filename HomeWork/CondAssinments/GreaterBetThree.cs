using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.CondAssinments
{
    internal class GreaterBetThree

    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 number");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int temp = a > b ? a : b;
            int greater=c > temp? c : temp;
            Console.WriteLine("greater num is: "+greater);
            


        }

    }
}
