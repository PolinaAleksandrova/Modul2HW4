using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Enums;

namespace Modul2HW4.Models
{
    public abstract class Animal
    {
        public string Name { get; init; }
        public Habitat Habitat { get; init; }
        public Weight Weight { get; init; }
    }
}
