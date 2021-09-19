using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Modul2HW4.Models;

namespace Modul2HW4.Helpers
{
    public class AnimalComparer : IComparer
    {
        public int Compare(object firstAnimal, object secondAnimal)
        {
            if (((Animal)firstAnimal).Weight.Value < ((Animal)secondAnimal).Weight.Value)
            {
                return -1;
            }
            else if (((Animal)firstAnimal).Weight.Value == ((Animal)secondAnimal).Weight.Value)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
