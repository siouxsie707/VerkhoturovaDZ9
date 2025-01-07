using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkhoturovaDZ92
{
    public class Rectangle : Point
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(string color, bool isVisible, int x, int y, double width, double height)
            : base(color, isVisible, x, y)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public override void DisplayState()
        {
            base.DisplayState();
            Console.WriteLine($"Ширина прямоугольника: {Width}, Высота: {Height}, Площадь: {CalculateArea()}");
        }
    }
}
