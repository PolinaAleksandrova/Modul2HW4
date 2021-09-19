using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Modul2HW4.Services.Abstractions;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Extensions;

namespace Modul2HW4
{
    public class AppStarter
    {
        private readonly IEnclosureService _enclosureService;
        private readonly ISortService _sortService;
        private readonly IAnimalProvider _animalProvider;
        private readonly IComparer _comparer;

        public AppStarter(IEnclosureService enclosureService, ISortService sortService, IAnimalProvider animalProvider, IComparer comparer)
        {
            _enclosureService = enclosureService;
            _sortService = sortService;
            _animalProvider = animalProvider;
            _comparer = comparer;
        }

        public void Run()
        {
            var random = new Random();
            for (var i = 0; i < 5; i++)
            {
                _enclosureService.Add(_animalProvider.Animals[random.Next(_animalProvider.Animals.Length)]);
            }

            var numberOfAnimals = _enclosureService.CountAnimalsTypes();
            _sortService.SortByWeight(_enclosureService.Animals, _comparer);
            var animal = _enclosureService.Animals.FindByName("Coyote");
        }
    }
}
