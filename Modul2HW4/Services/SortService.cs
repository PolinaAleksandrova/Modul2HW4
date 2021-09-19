using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Modul2HW4.Services.Abstractions;
using Modul2HW4.Models;

namespace Modul2HW4.Services
{
    public class SortService : ISortService
    {
        public void SortByWeight(Animal[] animals, IComparer comparer)
        {
            Array.Sort(animals, comparer);
        }
    }
}
