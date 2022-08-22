using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

          CanFly = true;
          CanTalk = true;
          Domestic = true;
          featherColor = "Name";
            





        }
        public string featherColor { get; set; }
        public bool CanFly { get; set; } 
        public bool CanTalk { get; set; }
        public bool Domestic { get; set; }

        public void PrintBirdFeature()
        {
            Console.WriteLine($"Bird 1 has{featherColor}. As with most birds, Bird1 {CanFly}.\n" +
                
                $"The following are some facts about Birds in general:\n" +
                $"-------------------------------------:\n" +
                $"With the exception of chickens and ostrichs, most birds {CanFly}\n" +
                $"Birds typically found in homes such as cocktiels and parrots are{Domestic}");







        }








    }
        





}
