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
            Console.WriteLine();
        }

        private static void NullConditionalOperator()
        {
            Console.WriteLine("3. Null conditional operator");

            Person person1 = null;
            Console.WriteLine(person1?.FullName);

            Person person2 = new Person("John", "Smith");
            Console.WriteLine(person2?.FullName);

            Console.WriteLine();
        }

        private static void NullCoalescingOperator()
        {
            Console.WriteLine("4. Null coalescing operator");

            int? a = null;
            Console.WriteLine(a ?? -1);

            string name1 = null;
            Console.WriteLine(name1 ?? "Unknown");

            string name2 = "Pistaba";
            Console.WriteLine(name2 ?? "Unknown");

            Console.WriteLine();
        }

        private static void GetterOnlyAutoProperties()
        {
            Console.WriteLine("5. Getter only auto properties");

            var point = new Point(5, 4);
            Console.WriteLine(point);

            // Error...
            // point.X = 10;

            Console.WriteLine();
        }

        private static void PropertyInitializers()
        {
            Console.WriteLine("6. Property initializers");

            var car = new Car();
            Console.WriteLine(car);

            Console.WriteLine();
        }
                
        private static void DictionaryInitializers()
        {
            Console.WriteLine("7. Dictionary initializers");

            var dictionary = new Dictionary<string, string>
            {
                ["A"] = "First",
                ["B"] = "Second",
                ["C"] = "Third"
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }

            Console.WriteLine();
        }

        private static void NameofOperator()
        {
            Console.WriteLine("8. Nameof operator");

            var johnSmith = new Person("John", "Smith");

            Console.WriteLine(nameof(Person));
            Console.WriteLine(nameof(Person.FirstName));

            Console.WriteLine(nameof(johnSmith));
            Console.WriteLine(nameof(johnSmith.FirstName));
            Console.WriteLine(nameof(johnSmith.FullName));

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Init();

            // C# 6.0 examples
            WriteLineUsingStatic();
            StringInterpolation();
            NullConditionalOperator();
            NullCoalescingOperator();
            GetterOnlyAutoProperties();
            PropertyInitializers();
            DictionaryInitializers();
            NameofOperator();
        }
    }
}
