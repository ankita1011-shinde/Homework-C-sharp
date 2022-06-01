using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Loops
{
    internal class Happynum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any num");
            int n=Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int evencount = 0;
            int oddcount = 0;

            while (n > 0)
            {
                rem = n % 10;
                if (rem % 2 == 0)
                {
                    oddcount++;
                    break;
                }

                n = n / 10;
            } 
                if(oddcount== 0)
                    Console.WriteLine("number is happynumber");
                else
                    Console.WriteLine("number is not happynumber");
                
               
            
           
            

        }
    }
}
