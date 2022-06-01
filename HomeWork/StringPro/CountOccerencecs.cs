using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringPro
{
    //To count occurence of a charachter in a given string
    class CounttOccerencecs
    {
        
        static void Main(string[] args)
        {
            //  Console.WriteLine("Enter any string");
            // string s= Console.ReadLine();

            string s = "   good morning friends";
            // Console.WriteLine("Enter the char to find occurence");
            s = s.Trim();
            Console.WriteLine("After triming white space: "+s);
            s =s.ToUpper();
            Console.WriteLine(s);
           
            int idx = s.IndexOf('G');
            //int all = s.IndexOf()

            Console.WriteLine("frist occurence of m: "+idx);


        }
    }
}
