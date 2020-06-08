using System;
using System.Collections.Generic;
using System.Text;

namespace PAISES.Infrastructure
{
    using PAISES.ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
