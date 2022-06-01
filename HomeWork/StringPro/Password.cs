using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringPro
{         //password length >5 
    //it should 1 capital, 1 smallcase,1 digit,1 special
     class Password
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password");
            string pswd = Console.ReadLine();
            int uppercount = 0;
            int lowercount = 0;
            int digitcount = 0;
            int symblcount = 0;
            
           if(pswd.Length < 5)

            Console.WriteLine("Error: Password length should be atleast 5");
            
           else
           {
                   char[] chr = pswd.ToCharArray();
                for (int i = 0; i < chr.Length; i++)
                {
                    if (chr[i] >= 'A' && chr[i] <= 'Z')
                    {
                        uppercount++;
                    }

                    else if (chr[i] >= 'a' && chr[i] <= 'z')
                    {
                        lowercount++;
                    }
                    else if (chr[i] >= '0' && chr[i] <= '9')
                    {
                        digitcount++;
                    }
                    else
                        symblcount++;


                }
           }
            if(uppercount ==0)
            {
                Console.WriteLine("please enter uppercase");
            }
            else if (lowercount==0)
            {
                Console.WriteLine("please enter lowercase");
            }
            else if(digitcount ==0)
            {
                Console.WriteLine("please enter digit");
            }
            else if (symblcount ==0)
            {
                Console.WriteLine("should contain spl char");
            }
            else
                Console.WriteLine("valid successful");
        }
    }

    class Longword   //find longest word and its occurencess.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence");
            string s = Console.ReadLine();
            int c = 0;
            string[] arr = s.Split(" ");
            string longword = arr[0];

            for(int i =0; i<arr.Length;i++)
            {
                if(longword.Length <= arr[i].Length)
                {
                    longword = arr[i];
                    c++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Longest word is: {longword} occurder in {c} times");

            bool ispalindrome = true;

            

            for (int i = 0; i < longword.Length / 2; i++)
            {
                if (longword[i] != longword[longword.Length - i - 1])
                {
                    ispalindrome = false;
                    break;
                }
            }
            if (ispalindrome)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not palindrome");
        }
    }

    class Email // email @ contain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter email id");
            string email = Console.ReadLine();

            Console.WriteLine(email.EndsWith("@gmail.com"));
        }
    }

    class longestPalindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence");
            string s = Console.ReadLine();

            bool ispalindrome = true;

            s = s.ToLower();

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    ispalindrome = false;
                    break;
                }
            }
            if (ispalindrome)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not palindrome");
        }
    }
}
