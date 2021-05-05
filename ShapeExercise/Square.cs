using System;
using System.Collections.Generic;
using System.Text;

namespace SquareExercise
{
    class Square : Shape
    {
        public static double Largest { get; set; }
        public static double Smallest { get; set; }
        public static double TotalArea { get; set; }
        public static double TotalPerimeter { get; set; }
        public static int Count { get; set; }

        public double Area { get; set; }

        public Square() : this(0) 
            {
            
            }
        public Square(double Side) : base(Side)
        {
            if (Side >= 0)
            {
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
                TotalPerimeter += 4 * Side;
            }
        }

        public override double RunCalculation()
        {
            this.Area = this.Side * this.Side;
            return this.Area;
        }
        

        

    }
}
