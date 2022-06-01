using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringPro
{
     class BuilderString
    {
        static void Main(string[] args)
        {


            StringBuilder sb = new StringBuilder("Ankita");
            sb.Append("Patil");
            Console.WriteLine(sb);

            sb.Insert(6, "Rohit");
            Console.WriteLine(sb);

            StringBuilder d= sb.Remove(11,5);


            Console.WriteLine(d);

            sb[0] = 'M';
            Console.WriteLine(sb);

         }

               
         
     }
}
