using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Challenges
{
    abstract class Animal
    {
        

        public bool Nocturnal { get; set; }

        public bool Carnivore { get; set; }

        public string Species { get; set; }

        public string Color { get; set; }

        public Animal () { }

        public Animal (string color, bool nocturnal, bool carnivore, string species)
        {
            color = Color;
            nocturnal = Nocturnal;
            carnivore = Carnivore;
            species = Species;
        }


    }

    class Pet : Animal
    {
        public Pet() { }
        public string Breed { get; set; }
        public string Size { get; set; }


    }
    

    class Cat : Pet
    {
        public string Name { get; set; }
        public string Owner { get; set; }
  
    }
}
