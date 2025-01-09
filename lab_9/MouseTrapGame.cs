using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class MouseTrapGame : IGame
    {
        public string Name => "Мышеловка";

        public void Play()
        {
            Console.WriteLine("Играем в мышеловку");
        }
    }
}
