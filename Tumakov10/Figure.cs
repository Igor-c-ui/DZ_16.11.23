using System;

namespace Tumakov10
{
    public abstract class Figure:IGeometricFigure
    {
        protected string color;
        protected bool isVisible;
        protected float _x;
        protected float _y;

        public Figure(string color)
        {
            this.color = color;
            this.isVisible = true;
            this._x = 0;
            this._y = 0;
        }

        public void MoveX(float x)
        {
            _x+= x;
        }

        public void MoveY(float y)
        {
            _y += y;
        }

        public void ChangeColor(string color)
        {
            this.color = color;
        }

        public void Change_Visibility()
        {
            isVisible = !isVisible;
            Console.WriteLine(isVisible ? "Figure is now visible." : "Figure is now invisible.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Color: {color}, Visibility: {(isVisible ? "Visible" : "Invisible")}, x = {_x}, y = {_y}");
        }

    }
}
