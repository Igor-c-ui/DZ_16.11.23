using System;

namespace Tumakov10
{
    internal interface IGeometricFigure
    {
        void MoveX(float x);
        void MoveY(float y);
        void ChangeColor(string color);
        void Change_Visibility();
        void DisplayInfo();
    }
}
