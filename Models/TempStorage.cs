using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4Foodie.Models
{       //storing the responses from the form
    public class TempStorage
    {
        private static List<RestaurantResponse> restaurants = new List<RestaurantResponse>();
        public static IEnumerable<RestaurantResponse> Restaurant => restaurants;
        public static void AddRestaurant(RestaurantResponse Restaurant)
        {
            restaurants.Add(Restaurant);
        }
    }
}
