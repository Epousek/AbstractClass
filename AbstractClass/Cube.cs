using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Cube : Body
    {
        private double _a;
        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Side can't be negative");
                else
                    _a = value;
            }
        }
        private double _b;
        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Side can't be negative");
                else
                    _b = value;
            }
        }
        private double _c;
        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Side can't be negative");
                else
                    _c = value;
            }
        }

        public Cube(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Cube(Ball ball, double a, double b)
        {
            A = a;
            B = b;
            C = ball.Volume() / (A * B);
        }

        public override double Surface()
        {
            return A * B * C;
        }

        public override double Volume()
        {
            return 2 * (A * B + A * C + B * C);
        }
    }
}
