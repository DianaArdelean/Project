using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>
            {
                new Birds(BirdsType.Sirloin),
                new Birds(BirdsType.Stork),
                new Birds(BirdsType.Woodpecker),
                new Mammals(MammalType.Cat),
                new Mammals(MammalType.Dog),
                new Mammals(MammalType.Horse)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"The animal: {animal.Name} makes sound {animal.MakesSound()}");
            }

            Console.ReadKey();
        }

    }
}
