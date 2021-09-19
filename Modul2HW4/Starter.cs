using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Modul2HW4.Helpers;
using Modul2HW4.Providers;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Services;
using Modul2HW4.Services.Abstractions;

namespace Modul2HW4
{
    public class Starter
    {
        public void StartApplication()
        {
            var serviceProvider = new ServiceCollection()
            .AddTransient<IAnimalProvider, AnimalProvider>()
            .AddTransient<IEnclosureService, EnclosureService>()
            .AddTransient<ISortService, SortService>()
            .AddTransient<IComparer, AnimalComparer>()
            .AddTransient<AppStarter>()
            .BuildServiceProvider();
            var appStarter = serviceProvider.GetService<AppStarter>();
            appStarter.Run();
        }
    }
}
