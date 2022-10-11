using DecoratorPattern1;
using System;

namespace Decorator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Character Boots = new Boots();
            Console.WriteLine("Default speed of character => " + Boots.WalkingSpeed());

            Boots = new PotionOfSpeed(Boots);
            Console.WriteLine("Speed of character with potion of speed => " + Boots.WalkingSpeed());

            Boots = new SlownessPotion(Boots);
            Console.WriteLine("Speed of character with slowness potion => " + Boots.WalkingSpeed());
        }
    }
}
