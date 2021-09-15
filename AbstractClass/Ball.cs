using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Ball : Body
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Radius can't be negative");
                else
                    _radius = value;
            }
        }

        public Ball(double r)
        {
            Radius = r;
        }

        public override double Surface()
        {
            return 4 * Math.PI * Radius;
        }

        public override double Volume()
        {
            return (4 / 3) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
