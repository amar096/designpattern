using System;

namespace Adater_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget targetFeature = new Adapter(new Adaptee());
            targetFeature.IndianPlugin();
        }
    }
}
