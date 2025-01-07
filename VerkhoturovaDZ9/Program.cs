using System;
using VerkhoturovaDZ92;

namespace VerkhoturovaDZ9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1");

            ICipher aCipher = new ACipher();
            ICipher bCipher = new BCipher();

            string input = "Привет, мир!";
            Console.WriteLine("Исходный текст: " + input);

            // ACipher
            string encodedA = aCipher.Encode(input);
            Console.WriteLine("Зашифрованный текст (A): " + encodedA);
            string decodedA = aCipher.Decode(encodedA);
            Console.WriteLine("Расшифрованный текст (A): " + decodedA);

            // BCipher
            string encodedB = bCipher.Encode(input);
            Console.WriteLine("Зашифрованный текст (B): " + encodedB);
            string decodedB = bCipher.Decode(encodedB);
            Console.WriteLine("Расшифрованный текст (B): " + decodedB);

            Console.WriteLine("Домашнее задание 10.1");

            Point point = new Point("Красный", true, 0, 0);
            point.DisplayState();
            point.Move(5, 3);
            point.DisplayState();

            Circle circle = new Circle("Синий", true, 10, 10, 5);
            circle.DisplayState();
            circle.Move(-5, -2);
            circle.DisplayState();

            Rectangle rectangle = new Rectangle("Зеленый", true, 0, 0, 10, 5);
            rectangle.DisplayState();
            rectangle.Move(3, 4);
            rectangle.DisplayState();
        }
    }
}