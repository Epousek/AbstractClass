using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball b = new Ball(10);
            Cylinder c = new Cylinder(b, 10);
            Console.WriteLine("Ball: " + b.Surface() + "/" + b.Volume() + "=" + b.SurfaceToVolume());
            Console.WriteLine("Cylinder: " + c.Surface() + "/" + c.Volume() + "=" + c.SurfaceToVolume());
        }
    }
}
