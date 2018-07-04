using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_CS.Src
{
    public class Program03
    {
        public Program03()
        {
            Console.WriteLine("\nOutput:");
            ForLoopExample forLoop = new ForLoopExample();
            forLoop.PrintA(5);
            forLoop.PrintB(5);
            forLoop.PrintC(5);
            forLoop.PrintD(5);
            forLoop.PrintE(5);
            forLoop.PrintF(5);
        }
    }

    internal class ForLoopExample
    {
        public void PrintA(int times)
        {
            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < times; j++)
                {
                    if (i >= j)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public void PrintB(int times)
        {
            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < times; j++)
                {
                    if (i <= j)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public void PrintC(int times)
        {
            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < times; j++)
                {
                    if (i == j)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public void PrintD(int times)
        {
            for (int i = times; i >= 0; i--)
            {
                for (int j = 0; j < times; j++)
                {
                    if (i <= j)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public void PrintE(int times)
        {
            for (int i = times; i >= 0; i--)
            {
                for (int j = 0; j < times; j++)
                {
                    if (i >= j)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public void PrintF(int times)
        {
            for (int i = times; i >= 0; i--)
            {
                for (int j = 0; j < times; j++)
                {
                    if (i == j)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
