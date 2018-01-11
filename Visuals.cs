using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
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
        }
    }
}
