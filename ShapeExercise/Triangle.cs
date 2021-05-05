using System;
using System.Collections.Generic;
using System.Text;

namespace SquareExercise
{
    class Triangle : Shape
    {
        public static double Largest { get; set; }
        public static double Smallest { get; set; }
        public static double TotalArea { get; set; }
        public static double TotalPerimeter { get; set; }
        public static int Count { get; set; }

        public double Height { get; set; }
        public double Area { get; set; }


        public Triangle () : this(0, 0)
        {

        }

        public Triangle (double Side, double Height) : base(Side)
        {
            if (Side >= 0 && Height >= 0)
            {
                this.Height = Height;
                Count++;
                if (Count == 1 || Side < Smallest)
                {
                    Smallest = Side;
                }
                if (Count == 1 || Side > Largest)
                {
                    Largest = Side;
                }
                TotalArea += RunCalculation();
                TotalPerimeter += TrianglePerimeterClaculations(Side, Height);
            }
        }

        public override double RunCalculation()
        {
            this.Area = (this.Side * this.Height) / 2;
            return this.Area;
        }

        private static double TrianglePerimeterClaculations (double side, double height)
        {
            if (side >= 0 && height >= 0)
            {
                double hypotenuse;
                double alpha;
                double lastSide;
                hypotenuse = Math.Sqrt((side / 2 * side / 2) + (height + height));
                alpha = Math.Atan(height / (side / 2));
                lastSide = side * Math.Tan(alpha);
                return hypotenuse + side + lastSide;
            }
            else
            {
                return 0;
            }
        }
    }
}
