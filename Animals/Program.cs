using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        enum TypeAnimal
        {
            Mamifere,
            Pasari
        }
        static void Main(string[] args)
        {
            var ListAnimals = new List<Animal>();

            ListAnimals.Add(new Animal { Name = "Cal", Sound = "dihaa" });
            ListAnimals.Add(new Animal { Name = "Vaca", Sound = "muuu" });
            ListAnimals.Add(new Animal { Name = "Oaie", Sound = "behehehe" });
            ListAnimals.Add(new Animal { Name = "Porc", Sound = "guitz" });
            


                foreach (var animal in ListAnimals)
                {
                    Console.WriteLine((string)TypeAnimal.Mamifere.ToString());
                }

                Console.ReadKey();
            }

        }

        


    }

    