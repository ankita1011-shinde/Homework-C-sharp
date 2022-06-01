using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.CondAssinments
{
    internal class ThreeDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n=Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int n1 = n;
            while(n>0)
            {
                c++;
                n = n / 10;
            }
            n = n1;
          
        }
    }
}
