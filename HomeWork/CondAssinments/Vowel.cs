using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.CondAssinments
{
    internal class Vowel
    {
        static void Main(string[] args)
        {
            char ch ='a';
            if(ch=='a' || ch <='e' || ch=='i' || ch=='o' || ch=='u')
            {
                Console.WriteLine("Vowel");
            }
            else
                Console.WriteLine("consonant");
        }
    }
}
