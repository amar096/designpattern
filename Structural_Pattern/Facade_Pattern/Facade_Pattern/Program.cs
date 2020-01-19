using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelKeeper hotelKeeper = new HotelKeeper();

            Veg vegMenu = hotelKeeper.GetVegMenu();
            NonVeg nonVeg = hotelKeeper.GetNonVegMenu();
            VegNonVeg both = hotelKeeper.GetVegnNonVegMenu();
        }
    }
}
