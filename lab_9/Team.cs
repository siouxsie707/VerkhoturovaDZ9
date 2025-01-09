using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class Team
    {
        public string Country { get; private set; }

        public Team(string country)
        {
            Country = country;
        }

        public void Compete(List<IGame> games)
        {
            Console.WriteLine($"Команда {Country} начинает соревнования:");
            foreach (var game in games)
            {
                Console.WriteLine($"- Игра: {game.Name}");
                game.Play();
            }
            Console.WriteLine();
        }
    }
}
