using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringPro
{
     class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the sentence");
            string s = Console.ReadLine();
            int countwords = 0;

            char[] arr = s.ToCharArray();
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]== ' ' && Char.IsLetter(s[i+1]) && (i>0))
                {
                    countwords++;
                }
               
            }
            countwords++;
            Console.WriteLine("nu of words"+countwords);
        }
    }

    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word 1");
            string s1 = Console.ReadLine();

            Console.WriteLine("enter word 2");
            string s2 = Console.ReadLine();

            s1 = s1.ToLower();
            s2 =s2.ToLower();

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Not Anagram");
            }
            else
            {
                char[] arr1 = s1.ToCharArray();
                char[] arr2 = s2.ToCharArray();

                Array.Sort(arr1);
                Array.Sort(arr2);

                //Console.WriteLine(arr1);
                //Console.WriteLine(arr2);

                if (arr1.ToString().Equals(arr2.ToString()))

                {
                    Console.WriteLine("anagram");

                }
                else
                {
                    Console.WriteLine("Not Anagram");
                }

            }
          
            
        }
    }

    class CountString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  sentence");
            string s1=Console.ReadLine();

            Console.WriteLine("enter word to be search");
            string w = Console.ReadLine();

            int c = 0;
            string[] a = s1.Split(" ");
            for(int i = 0; i<a.Length;i++)
            {
                if (a[i] == w)
                    c++;

            }
            Console.WriteLine("count "+c);
        }
    }
}
