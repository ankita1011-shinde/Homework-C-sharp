using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringPro
{
    class AnagramString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word 1");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter word 2");
            string s2 = Console.ReadLine();

            // Console.WriteLine(s1==s2);


            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();

            Array.Sort(a1);
            Array.Sort(a2);

            string ss1 = new String(a1);
            string ss2 = new String(a2);
            if (ss1 == ss2)
            {
                Console.WriteLine("Anagram");
            }
            else
                Console.WriteLine("Not Anagram");

        }

    }
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1;
            int c = Convert.ToInt32(Console.ReadLine());
            int n3;
            //Console.WriteLine(n1+" "+n2);

            for (int i = 2; i < c; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(c);
                n1 = n2;
                n2 = n3;
            }

        }
    }
}