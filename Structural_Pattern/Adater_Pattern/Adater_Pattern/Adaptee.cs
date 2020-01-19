using System;
using System.Collections.Generic;
using System.Text;

namespace Adater_Pattern
{
    class Adaptee : IAdaptee
    {
        public void EuropePlugin()
        {
            Console.WriteLine("European Plugin System");
        }
    }
}
