using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Loops
{
    internal class PrintSquare
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=10;i++)
            {
                int sq = n * i;
                Console.WriteLine(sq);
            }
            

           
                
           
        }
    }
}
