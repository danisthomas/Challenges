using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar_Console
{
    class Program
    {
        readonly List<string> gameSequence = new List<string>;
        private string textFile = File.ReadAllText(@"D:\ElevenFiftyProjects\DotNetProjects\Challenges\Drofsnar_Console\game-sequence.txt", Encoding.UTF8);
        private List<int> gameScore = new List<int>;
        static void Main(string[] args)
        {
            var game = new Game();
            game.Bird = 10;
            game.CrestedIbis = 100;
            game.GreatKiskudee = 300;
            game.RedCrossbill = 500;
            game.RedneckedPharlarope = 700;
            game.EveningGrosbeak = 1000;
            game.GreaterPrairieChicken =2000;
            game.IcelandGull = 3000;
            game.OrangeBelliedParrot = 5000;
            game.VulnerableBirdHunter = 200;
           

        }
        public GetTotalScore()
        {
            List<int> gameScore = new List<int>();
            foreach (var bird in File.ReadLines(@"D:\ElevenFiftyProjects\DotNetProjects\Challenges\Drofsnar_Console\game-sequence.txt", Encoding.UTF8))
            {
                gameSequence.Add(bird);
                
            }

            foreach(var bird in gameSequence)
            {
                if(bird == )
            }
            
        }
    }
}




}
    

