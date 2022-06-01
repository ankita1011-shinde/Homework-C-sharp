using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.CondAssinments
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());

            if(num%4==0)
            {
                Console.WriteLine("Leap Year");
            }
            else
                Console.WriteLine("not Leap year");
        }
    }
}
