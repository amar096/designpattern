using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    /// <summary>
    /// Facade Class which will hide the details of hotels and its restaurants. 
    /// This Class will take order from the Clients and do the internal research for what order to get from where.
    /// </summary>
   public  class HotelKeeper
    {
        public Veg GetVegMenu()
        {
            VegRestaurants vegRestaurants = new VegRestaurants();
            Veg vegMenu = (Veg)vegRestaurants.GetMenu();
           return vegMenu;
        }
        public NonVeg GetNonVegMenu()
        {
            NonVegRestaurants vegRestaurants = new NonVegRestaurants();
            NonVeg nonVegMenu = (NonVeg)vegRestaurants.GetMenu();
            return nonVegMenu;
        }

        public VegNonVeg GetVegnNonVegMenu()
        {
            VegNonVegRestaurants vegRestaurants = new VegNonVegRestaurants();
            VegNonVeg vegNonVegMenu = (VegNonVeg)vegRestaurants.GetMenu();
            return vegNonVegMenu;
        }
    }
}
