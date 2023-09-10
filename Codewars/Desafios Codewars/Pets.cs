using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars.Desafios
{
    public abstract class Pets
    {
        class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static void OrderByEx1()
        {
            Pet[] pets = { new Pet { Name="Barley", Age=8 },
                   new Pet { Name="Boots", Age=4 },
                   new Pet { Name="Whiskers", Age=1 },
                   new Pet { Name="Bruce", Age=3 },
                   new Pet { Name="Mary", Age=2 },
                   new Pet { Name="Chiclete", Age=5 },
                   new Pet { Name="Ringo", Age=3 }
            };

            IEnumerable<Pet> query = pets.OrderBy(pet => pet.Age).Take(3);

            foreach (Pet pet in query)
            {
                Console.WriteLine("{0} - {1}", pet.Name, pet.Age);

            }
        }
    }
}
