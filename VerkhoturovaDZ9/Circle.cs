using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkhoturovaDZ92
{
    public class Circle : Point
    {
        public double Radius { get; private set; }

        public Circle(string color, bool isVisible, int x, int y, double radius)
            : base(color, isVisible, x, y)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void DisplayState()
        {
            base.DisplayState();
            Console.WriteLine($"Радиус окружности: {Radius}, Площадь: {CalculateArea()}");
        }
    }
}
