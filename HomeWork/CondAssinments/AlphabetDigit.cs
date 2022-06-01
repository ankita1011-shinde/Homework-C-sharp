
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.CondAssinments
{
    internal class AlphabetDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character");
           char ch=Convert.ToChar(Console.Read());

            if((ch=='a' || ch=='z') && (ch=='A' || ch=='Z'))
            {
                Console.WriteLine("It is character");
            }
            else if(ch=='1' || ch=='9')
            {
                Console.WriteLine("It is digit");
            }
            else
                Console.WriteLine("Special character");
        }
    }
}
