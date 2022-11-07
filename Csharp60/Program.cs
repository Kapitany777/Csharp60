using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace Csharp60
{
    class Program
    {
        private static void WriteLineUsingStatic()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Console.WriteLine");
            Console.WriteLine();

            BackgroundColor = Black;
            ForegroundColor = Gray;
            WriteLine("WriteLine");
            WriteLine();
        }

        static void Main(string[] args)
        {
            // C# 6.0 examples

            WriteLineUsingStatic();
        }
    }
}
