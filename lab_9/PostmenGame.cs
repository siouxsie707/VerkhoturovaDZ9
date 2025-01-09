using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class PostmenGame : IGame
    {
        public string Name => "Почтальоны";

        public void Play()
        {
            Console.WriteLine("Играем в почтальонов");
        }
    }
}
