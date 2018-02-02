using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {

            int userInput = ("1");
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Hello World");
                    break;
                case 2:
                    Console.WriteLine("Hej Världen");
                    break;
                case 3:
                    Console.WriteLine("Hola El Mundo");
               
            }
            Thread.Sleep(600);




            Stopwatch sw = new Stopwatch();
            sw.Start();

            while (sw.Elapsed < TimeSpan.FromSeconds(1))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\n     00\n     00");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n     00  \n    0  0\n    0  0\n     00");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n     0 0  \n    0   0 \n   0     0\n   0     0\n    0   0 \n     0 0 ");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("     0  0  \n    0    0 \n   0      0\n  0        0\n  0        0\n   0      0\n    0    0 \n     0  0 ");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n     0 0  \n    0   0 \n   0     0\n   0     0\n    0   0 \n     0 0 ");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n     00  \n    0  0\n    0  0\n     00");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\n     00\n     00");
                Console.Clear();
            }
            Console.WriteLine("BOOOM!!");
            Console.ReadKey();
        }
    }
}
