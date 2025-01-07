using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkhoturovaDZ92
{
    public abstract class Figure
    {
        public string Color { get; set; }
        public bool IsVisible { get; set; }

        protected Figure(string color, bool isVisible)
        {
            Color = color;
            IsVisible = isVisible;
        }

        public virtual void Move(int dx, int dy)
        {
            // Переопределяется в дочерних классах
        }

        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }

        public void ToggleVisibility()
        {
            IsVisible = !IsVisible;
        }

        public virtual void DisplayState()
        {
            Console.WriteLine($"Цвет: {Color}, Видимость: {IsVisible}");
        }
    }
}