using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Models.Animals.Mammals.Artiodactyls;
using Modul2HW4.Models.Animals.Mammals.Insectivores;
using Modul2HW4.Models.Animals.Mammals.Predators;
using Modul2HW4.Models;
using Modul2HW4.Enums;
using Modul2HW4.Models.Animals;

namespace Modul2HW4.Providers
{
    public class AnimalProvider : IAnimalProvider
    {
        public AnimalProvider()
        {
            Animals = new Animal[]
            {
                new Antelope
                {
                    Name = "Impala",
                    Habitat = Habitat.SouthernAfrica,
                    Weight = new Weight { Value = 60 }
                },
                new BactrianCamel
                {
                    Name = "BactrianCamel",
                    Habitat = Habitat.CentralAsia,
                    Weight = new Weight { Value = 480 }
                },
                new BlindMole
                {
                    Name = "BlindMole",
                    Habitat = Habitat.NorthAmerica,
                    Weight = new Weight { Value = 71 }
                },
                new Hedgehog
                {
                    Name = "Hedgehog",
                    Habitat = Habitat.SouthernAfrica,
                    Weight = new Weight { Value = 60 }
                },
                new BrownBear
                {
                    Name = "BrownBear",
                    Habitat = Habitat.NorthAmerica,
                    Weight = new Weight { Value = 500 }
                },
                new Coyote
                {
                    Name = "Coyote",
                    Habitat = Habitat.NorthAmerica,
                    Weight = new Weight { Value = 21 }
                },
                new FennecFox
                {
                    Name = "FennecFox",
                    Habitat = Habitat.NorthAmerica,
                    Weight = new Weight { Value = 500 }
                }
            };
        }

        public Animal[] Animals { get; }
    }
}
