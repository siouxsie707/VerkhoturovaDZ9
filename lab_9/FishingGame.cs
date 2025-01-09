using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class FishingGame : IGame
    {
        public string Name => "Рыбалка";

        public void Play()
        {
            Console.WriteLine("Играем в рыбалку");
        }
    }
}
