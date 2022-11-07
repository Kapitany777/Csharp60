﻿using System;
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
        private static void Init()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void WriteLineUsingStatic()
        {
            Console.WriteLine("1. Using static type directive");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Console.WriteLine");
            Console.WriteLine();

            BackgroundColor = Black;
            ForegroundColor = Gray;
            WriteLine("WriteLine");
            WriteLine();
        }

        private static void StringInterpolation()
        {
            Console.WriteLine("2. String interpolation");

            int a = 8;
            int b = 7;

            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(string.Format("{0} + {1} = {2}", a, b, a + b));
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a:#0.0} + {b:#0.0} = {a + b:#0.0}");
        }

        static void Main(string[] args)
        {
            Init();
            
            // C# 6.0 examples
            WriteLineUsingStatic();
            StringInterpolation();
        }
    }
}
