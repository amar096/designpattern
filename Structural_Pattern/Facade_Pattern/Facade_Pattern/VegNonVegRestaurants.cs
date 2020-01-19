using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    class VegNonVegRestaurants : IHotel
    {
        public Menu GetMenu()
        {
            VegNonVeg both = new VegNonVeg();
            return both;
        }
    }
}
