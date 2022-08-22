using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {

        public Reptile()
        {
            Age = 0;
            TreeRockGround ="Tree";
            CarnivoreOmnivore = "Carnivore";
            LayEggs = false;

        }
        public int Age { get; set; }
        public string TreeRockGround { get; set; }
        public string CarnivoreOmnivore { get; set; }
        public bool LayEggs { get; set; }

        public void PrintReptileFeature()
        {
            Console.WriteLine($"This lizard is{2} years old. Average life span of a lizard is about 5 years.\n" +
                $"Lifespan will depend on overall care and health of your lizard.\n" +
                $"The following applies to most lizards:\n" +
                $"--------------------------------------:\n" +
                $"They live in trees{TreeRockGround}\n" +
                $"They are Carnivore{CarnivoreOmnivore}\n" +
                $"Most do lay eggs, although not all{LayEggs}");





        }









    }











}
