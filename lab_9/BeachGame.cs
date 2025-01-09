using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class BeachGame : IGame
    {
        public string Name => "Пляж";

        public void Play()
        {
            Console.WriteLine("Играем в пляж");
        }
    }
}
