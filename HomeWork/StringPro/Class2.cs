using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringPro
{
   class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");

            
            string s=Console.ReadLine();
            s = s.ToUpper();
            Console.WriteLine(s);
            Console.WriteLine("Length "+s.Length);   // length

            s = s.Trim();
            Console.WriteLine("length is "+s.Length);  //remove space before n after string

            string s2 = "thinkquotient";
            Console.WriteLine("s2");

            int idx = s2.IndexOf('i');               //index of char
            Console.WriteLine("index of i is: "+idx);

            int lidx = s2.LastIndexOf('t');         //index from last
            Console.WriteLine("last index of t is: "+lidx);

            Console.WriteLine(s2.Substring(5));     //string start from that num

           // Console.WriteLine(s2.Substring(6,9));     // length which we have to print

            char[] sn = s2.ToCharArray();            //
            sn[0] = 'S';
            string s3 = new string(sn);
            Console.WriteLine(s3);

        }
    }
}
