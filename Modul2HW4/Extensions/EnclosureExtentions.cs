using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models;

namespace Modul2HW4.Extensions
{
    public static class EnclosureExtentions
    {
        public static Animal FindByName(this Animal[] animals, string name)
        {
            foreach (var item in animals)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
