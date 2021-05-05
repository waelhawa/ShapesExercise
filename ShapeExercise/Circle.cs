using System;
using System.Collections.Generic;
using System.Text;

namespace SquareExercise
{
    class Circle : Shape
    {
        public static double Largest { get; set; }
        public static double Smallest { get; set; }
        public static double TotalArea { get; set; }
        public static double TotalPerimeter { get; set; }
        public static int Count { get; set; }

        public double Area { get; set; }
        public Circle() : this(0)
        {
        }

        public Circle (double Radius) : base(Radius)
        {
            if (Radius >= 0)
            {
                Count++;
                if (Count == 1 || Radius < Smallest)
                {
                    Smallest = Radius;
                }
                if (Count == 1 || Radius > Largest)
                {
                    Largest = Radius;
                }
                TotalArea += RunCalculation();
                TotalPerimeter += (2 * Math.PI * Radius);
            }
        }

        public override double RunCalculation()
        {
            this.Area = Math.PI * this.Side * this.Side;
            return this.Area;
        }

    }
}
