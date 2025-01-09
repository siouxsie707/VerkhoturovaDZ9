using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class ObstacleCourseGame : IGame
    {
        public string Name => "Полоса препятствий";

        public void Play()
        {
            Console.WriteLine("Играем в полосу препятствий");
        }
    }
}
