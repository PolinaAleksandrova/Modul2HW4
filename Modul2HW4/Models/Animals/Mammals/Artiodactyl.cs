using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Enums;

namespace Modul2HW4.Models.Animals.Mammals
{
    public abstract class Artiodactyl : Mammal
    {
        public abstract ArtiodactylType ArtiodactylType { get; }
    }
}
