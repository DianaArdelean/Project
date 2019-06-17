using System;
using System.Collections.Generic;

namespace Animals_Refactored
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var animal in GetAnimals())
            {
                Console.WriteLine($"Animalul: {animal.Name}, face sunetul {animal.Sound}");
            }

            Console.ReadKey();
        }

        public static List<Animal> GetAnimals() 
        {
            return new List<Animal>
            {
                new Animal( "Cal","dihaha"),
                new Animal( "Oaie","behehe"),
                new Animal( "Porc","guitz"),
                new Animal( "Vaca","muuu")
            };
        }
    }
}
