using System;
using System.Collections.Generic;
using System.Text;

namespace Adater_Pattern
{
    class Adapter : ITarget
    {
        private IAdaptee _adaptee;

        public Adapter(IAdaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public void IndianPlugin()
        {
            Console.WriteLine("Adapter to make IndianPlugin Compatible to EuropeanPlugin");
            _adaptee.EuropePlugin();
        }
    }
}
