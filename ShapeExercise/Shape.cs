using System;
using System.Collections.Generic;
using System.Text;

namespace SquareExercise
{
    class Shape
    {
        public static int Count { get; set; }
        protected double Side { get; set; }

        public Shape() : this(0)
        {

        }

        public Shape (double Side)
        {
            if (Side >= 0)
            {
                this.Side = Side;
                Count++;
            }
        }

        public virtual double RunCalculation()
        {
            return 0;
        }
    }
}
