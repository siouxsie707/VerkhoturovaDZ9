using System;

namespace VerkhoturovaDZ9
{
    class Program
    {
        static void Main(string[] args)
        {
            ICipher aCipher = new ACipher();
            ICipher bCipher = new BCipher();

            string input = "Hello, World!";
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
        }
    }
}