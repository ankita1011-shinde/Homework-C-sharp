using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringPro
{
     class Pallindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string ");
            string s = Console.ReadLine();
           // string rev = " ";
            bool ispalindrome = true;

            s= s.ToLower();

            for(int i=0;i<s.Length/2;i++)
            {
                if(s[i]!=s[s.Length-i-1])
                {
                    ispalindrome = false;
                    break;
                }
            }
            if(ispalindrome)

           /* for(int i = s.Length-1; i>=0; i--)
            {
                rev = rev + s[i];
            }*/
           // Console.WriteLine(rev);
           /* if (rev == s)
            {
           }*/
                Console.WriteLine("Palindrome");
            
            else
                Console.WriteLine("not palindrome");
        }
    }
}
