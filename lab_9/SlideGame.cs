using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class SlideGame : IGame
    {
        public string Name => "Горка";

        public void Play()
        {
            Console.WriteLine("Играем в горку");
        }
    }
}
