using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to do? (Basics or Circles) <- Type one");
            string choice = Console.ReadLine().ToLower();

            if (choice == "basics" || choice == "basic")
            {
                Basics();
            }
            else if (choice == "circles" || choice == "circle")
            {
                Circles();
            }
            else
            {
                Console.WriteLine("Choice not recognized. Try again.");
            }

        }

        public static void Circles()
        {
            Console.WriteLine("What is the radius of your circle? ");
            int r = int.Parse(Console.ReadLine());
            double area = AreaOfCircle(r);
            Console.WriteLine($"The area of a circle with radius of {r} is {area}.");
        }

        public static double AreaOfCircle(int rad)
        {
            double a = Math.PI * Math.Pow(rad, 2) ;

            return a;
        }

        public static void Basics()
        {
            Console.WriteLine("Input Integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Integer: (Not 0) ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("What would you like to do? (Add, Sub, Div, Mult) <- Type one");
            string op = Console.ReadLine().ToLower();

            if (op == "add" || op == "addition")
            {
                Console.WriteLine("Addition Chosen.");
                Console.WriteLine(Add(a, b));
            }
            else if (op == "sub" || op == "subtrack")
            {
                Console.WriteLine("Subtraction Chosen.");
                Console.WriteLine(Subtract(a, b));
            }
            else if (op == "div" || op == "divide" || op == "division")
            {
                Console.WriteLine("Division Chosen.");
                Console.WriteLine(Divide(a, b));
            }
            else if (op == "mult" || op == "multiplication" || op == "multiply")
            {
                Console.WriteLine("Multiplication Chosen.");
                Console.WriteLine(Multiply(a, b));
            }
            else
            {
                Console.WriteLine("Didnt choose one of the options please retry.");
            }
        }

        public static string Add(int a, int b)
        {
            string rString = "";
            rString += $"{a} + {b} = {a + b}";

            return rString;
        }

        public static string Subtract(int a, int b)
        {
            string rString = "";
            rString += $"{a} - {b} = {a - b}";

            return rString;
        }

        public static string Multiply(int a, int b)
        {
            string rString = "";
            rString += $"{a} * {b} = {a * b}";

            return rString;
        }

        public static string Divide(int a, int b)
        {
            string rString = "";
            int quotient = a / b;
            int remainder = a % b;
            rString += $"{a} / {b} = {quotient} remainder {remainder}.";

            return rString;
        }
    }
}
