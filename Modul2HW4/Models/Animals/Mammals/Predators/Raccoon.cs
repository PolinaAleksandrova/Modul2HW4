using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Enums;

namespace Modul2HW4.Models.Animals.Mammals.Predators
{
    public class Raccoon : Predator
    {
        public override PredatorType PredatorType => PredatorType.Racoon;
    }
}
