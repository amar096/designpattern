using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class VegRestaurants
    {
        public Menu GetMenu()
        {
            Veg veg = new Veg();
            return veg;
        }
    }
}
