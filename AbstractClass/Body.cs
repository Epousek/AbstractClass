using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Body
    {
        abstract public double Surface();

        abstract public double Volume();

        public double SurfaceToVolume()
        {
            return Surface() / Volume();
        }
    }
}
