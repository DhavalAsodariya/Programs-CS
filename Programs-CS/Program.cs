using Programs_CS.Src;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string line in System.IO.File.ReadAllLines("ReadMe.txt"))
            {
                Console.WriteLine(line);
            }
            
            Console.WriteLine("\nEnter the program number to run:");
            switch (Console.ReadLine())
            {
                case "1":
                    new Program01();
                    break;
                case "2":
                    new Program02();
                    break;
                case "3":
                    new Program03();
                    break;
                default:
                    Console.WriteLine("Invalid input!!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
