using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal *
            // give this class 4 members that all Animals have in common*


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            //object initalizer syntax

            var bird1 = new Bird();
            bird1.CanTalk = true;
            bird1.CanFly = true;
            bird1.featherColor = "Red";
            bird1.Domestic = false;

           
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var reptile1 = new Reptile();
            reptile1.LayEggs = true;
            reptile1.CarnivoreOmnivore = "Carnivore";
            reptile1.TreeRockGround = "Tree";
            reptile1.Age = 4;

            

          




            
        }
    }
}
