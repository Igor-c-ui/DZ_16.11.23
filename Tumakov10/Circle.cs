using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov10
{
    public class Circle : Point
    {
        private double radius;

        public Circle(string color, double radius) : base(color)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Circle, Radius: {radius}, Area: {CalculateArea()}");
            _x = 0;
            _y = 0;
        }
    }

}
