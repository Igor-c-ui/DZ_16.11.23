using System;

namespace Tumakov10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Упр. 10.1
            ACipher aCipher = new ACipher();
            Console.WriteLine(aCipher.encode("Hello"));

            BCipher bCipher = new BCipher();
            Console.WriteLine(bCipher.encode("Hello"));
            Console.WriteLine(bCipher.decode(bCipher.encode("Hello")));

            //ДЗ. 10.1
            Circle circle = new Circle("Red", 5);
            Rectangle rectangle = new Rectangle("Blue", 4, 6);

            circle.DisplayInfo();
            rectangle.DisplayInfo();

            circle.MoveX(2);
            rectangle.MoveY(3);

            circle.Change_Visibility();
            rectangle.ChangeColor("Green");

            circle.DisplayInfo();
            rectangle.DisplayInfo();
            Console.ReadKey();
        }
    }
}
