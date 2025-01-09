using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Team russia = new Team("Россия");
            Team france = new Team("Франция");
            Team china = new Team("Китай");
            Team kazakhstan = new Team("Казахстан");

            var games = new List<IGame>
        {
            new BeachGame(),
            new MouseTrapGame(),
            new SeaGame(),
            new FishingGame(),
            new PostmenGame(),
            new SlideGame(),
            new ObstacleCourseGame()
        };

            russia.Compete(games);
            france.Compete(games);
            china.Compete(games);
            kazakhstan.Compete(games);

        }
    }
 }

