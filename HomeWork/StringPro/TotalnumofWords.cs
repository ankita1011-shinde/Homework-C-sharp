using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringPro
{
    class TotalnumofWords
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string[] nm = { "om", "ajay", "piya", "tiya" };
                int temp = 0;
                for(int i=0;i<=nm.Length-1;i++)
                {
                    for(int j=0;j<nm.Length;j++)
                    {
                        if(nm[j].CompareTo(nm[i])==0)
                        {
                            string t = nm[j];
                            nm[j] = nm[j + 1];
                            nm[j + 1] = t;
                        }
                    }
                }
                foreach(string s in nm)
                    Console.WriteLine(s);
            }
        }
    }
}
