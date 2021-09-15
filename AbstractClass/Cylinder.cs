using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Cylinder : Body
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
        private double _height;
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Height can't be negative");
                else
                    _height = value;
            }
        }

        public Cylinder(double r, double h)
        {
            Radius = r;
            Height = h;
        }

        public Cylinder(Ball b, double h)
        {
            Height = h;
            Radius = Math.Sqrt(b.Volume() / (Math.PI * Height));
        }

        public override double Surface()
        {
            return 2 * Math.PI * Radius * (Radius + Height);
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }
    }
}
