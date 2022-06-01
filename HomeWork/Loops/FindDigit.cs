using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Loops
{
    internal class FindDigit
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n=Convert.ToInt32(Console.ReadLine());
            int c = 0;
            while(n>0)
            {
                n = n / 10;
                c++;

            }
            Console.WriteLine(c);
        }
    }
}
