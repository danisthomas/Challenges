using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar_Console
{
    enum Bird
    {
        Bird = 1,

    }

    class Game
    {



        public int Bird { get; set; }
        public int CrestedIbis { get; set; }
        public int GreatKiskudee { get; set; }
        public int RedCrossbill { get; set; }
        public int RedneckedPharlarope { get; set; }
        public int EveningGrosbeak { get; set; }
        public int GreaterPrairieChicken { get; set; }
        public int IcelandGull { get; set; }
        public int OrangeBelliedParrot { get; set; }
        public int VulnerableBirdHunter { get; set; }
        public int InvicibleBirdHunter { get; set; }

        public int Lives { get; set; }

        public int StartingScore = 5000;
        public int StartingLives = 3;

        public Game() { }





    }
}
