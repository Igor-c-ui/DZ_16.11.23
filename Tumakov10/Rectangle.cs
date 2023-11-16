using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov10
{
    public class Rectangle : Point
    {
        private double width;
        private double height;

        public double CalculateArea()
        {
            return width * height;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Rectangle, Width: {width}, Height: {height}, Area: {CalculateArea()}");
        }

        public Rectangle(string color, float width, float height) : base(color)
        { 
            this.width = width;
            this.height = height;
            _x = 0;
            _y = 0;
        }
}
}
