using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models;
using Modul2HW4.Services.Abstractions;

namespace Modul2HW4.Services
{
    public class EnclosureService : IEnclosureService
    {
        public EnclosureService()
        {
            Animals = new Animal[0];
        }

        public Animal[] Animals { get; set; }

        public int CountAnimalsTypes()
        {
            var types = new Type[1] { Animals[0].GetType() };
            var match = false;

            for (var i = 1; i < Animals.Length; i++)
            {
                for (var j = 0; j < types.Length; j++)
                {
                    if (Animals[i].GetType() == types[j])
                    {
                        match = true;
                    }
                }

                if (!match)
                {
                    var oldTypes = types;
                    types = new Type[types.Length + 1];

                    for (var k = 0; k < oldTypes.Length; k++)
                    {
                        types[k] = oldTypes[k];
                    }

                    types[types.Length - 1] = Animals[i].GetType();
                }
                else
                {
                    match = false;
                }
            }

            return types.Length;
        }

        public bool Add(Animal animal)
        {
            var animals = Animals;

            Animals = new Animal[Animals.Length + 1];

            for (var i = 0; i < Animals.Length - 1; i++)
            {
                Animals[i] = animals[i];
            }

            Animals[Animals.Length - 1] = animal;

            return true;
        }
    }
}
