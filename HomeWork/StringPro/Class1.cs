using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringPro
{
     class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            string s = Console.ReadLine();
            
             s =s.ToUpper(); //  uppercase
            Console.WriteLine(s);
            Console.WriteLine("length "+s.Length); //length
            Console.Write("reverse order"); // reverse order
            for(int i =s.Length-1;i<=0;i--)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("aftr replacing character replce by next char");
            for (int i =0;i<s.Length;i++)
            {
                Console.Write(Convert.ToChar(s[i]+1));
                
            }
                

            
        }
    }
    static class vehicle
    {
        public  static string color = "black";


        static vehicle()
        {
            Console.WriteLine("static constructor");

        }

        public static int add(int a,int b)
        {
            return a + b;
        }

    }

   class abc
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Addition is: "+ vehicle.add(2, 4));

            vehicle.color = "black";
            Console.WriteLine( "Color is: "+ vehicle.color);

           
            Console.WriteLine("Addition is: " + vehicle.add(8, 3));

            vehicle.color = "white";
            Console.WriteLine("Color is: " + vehicle.color);

        }
    }
}
