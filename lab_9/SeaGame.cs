using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class SeaGame : IGame
    {
        public string Name => "Море";

        public void Play()
        {
            Console.WriteLine("Играем в море");
        }
    }
}
