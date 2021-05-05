using System;
using System.Collections.Generic;

namespace SquareExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double side;
            bool looper = true;
            List<Shape> squares = new List<Shape>();
            Shape one = new Square(14);
            Shape two = new Triangle(12, 14);
            Shape three = new Circle(14);
            Console.WriteLine(Shape.Count);
            Console.WriteLine(Square.Count);
            Console.WriteLine((one as Square).Area);
            Console.WriteLine(Triangle.Count);
            Console.WriteLine((two as Triangle).Area);
            Console.WriteLine(Circle.Count);
            Console.WriteLine((three as Circle).Area);

        }

        public static string DoubleEntry(string phrase, string error)
        {
            string text;
            double doubleNumber;
            while (true)
            {
                Console.Write(phrase);
                text = Console.ReadLine().Trim().ToLower();
                if (text != "q")
                {
                    if (double.TryParse(text, out doubleNumber))
                    {
                        return text;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else
                {
                    return text;
                }
            }
        } //end doubleEntry

        public static bool ContinueEntry(string phrase, string error)
        {
            string text;
            while (true)
            {
                Console.Write(phrase);
                text = Console.ReadLine().Trim().ToLower();

                switch (text)
                {
                    case "y":
                    case "yes":
                        return true;


                    case "n":
                    case "no":
                        return false;

                    case "q":
                    case "quit":
                        return true;

                    default:
                        Console.WriteLine(error);
                        break;
                }
            }
        } //end ContinueEntry
    }
}
