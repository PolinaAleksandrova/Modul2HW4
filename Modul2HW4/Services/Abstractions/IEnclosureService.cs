using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models;

namespace Modul2HW4.Services.Abstractions
{
    public interface IEnclosureService
    {
        Animal[] Animals { get; }
        public int CountAnimalsTypes();
        public bool Add(Animal animal);
    }
}
