using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class NonVegRestaurants
    {
        public Menu GetMenu()
        {
            NonVeg nonVeg = new NonVeg();
            return nonVeg;
        }
    }
}
