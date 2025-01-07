using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkhoturovaDZ92
{
    public class Point : Figure
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(string color, bool isVisible, int x, int y) : base(color, isVisible)
        {
            X = x;
            Y = y;
        }

        public override void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public override void DisplayState()
        {
            base.DisplayState();
            Console.WriteLine($"Положение точки: ({X}, {Y})");
        }
    }
}