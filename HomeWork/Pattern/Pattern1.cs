using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Pattern
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

        }
    }
    /* *#
     * *#*
     * *#*#
     * *#*#*
     */

    class Pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write("*");

                    }
                    else
                        Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }


    /*  1
     *  21
     *  123
     *  4321
     *  12345
     */

    class Pattern3
    {
        static void Main(string[] args)

        {
            int k;
            for (int i = 1; i <= 5; i++)
            {
                k = 1;
                for (int j = i; j >= 1; j++)
                {
                    if (i % 2 == 0)

                        Console.Write(j);

                    else
                    {
                        Console.Write(k);
                        k++;
                    }
                }
                Console.WriteLine();
            }
        }
    }

    /* 1
     * 12
     * 123
     * 1234
     * 12345
     */

    class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }

    /*  A
     *  AB
     *  ABC
     *  ABCD
     *  ABCDE
     */


    class Pattern5
    {
        static void Main(string[] args)
        {
            int ch = 65;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(ch + j));

                }
                Console.WriteLine();
            }
        }
    }

    /* *
     * **
     * ***
     * ****
     * *****
     */


    class Pattern6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
    /*  A
     *  BB
     *  CCC
     *  DDDD
     *  EEEE
     */

    class Pattern7
    {
        static void Main(string[] args)
        {
            int ch = 65;
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write((char)(ch + i));

                }
                Console.WriteLine();
            }
        }
    }

    /*       *
     *      **
     *     ***
     *    ****
     *   *****
     */
    class Pattern8
    {
        static void Main(string[] args)
        {
            int j;
            for (int i = 1; i <= 5; i++)
            {
                for (j = 2 * (5 - i); j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    /*   1
     *   22
     *   333
     *   4444
     *   55555
     */

    class Pattern9
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class A
    {
        static void Main(string[] args)
        {


            int flag = 0;
            Console.Write("Enter the Number to check Prime: ");
           int n = int.Parse(Console.ReadLine());
            //m = n / 2;
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }

    }
}



