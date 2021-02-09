using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Assignment4Foodie.Controllers
{
    public class RestaurantList
    {
        public RestaurantList(int rank)
        {
            Rank = rank;
        }
        [Required]
        //only use a get because we want the rank to be read only 
        public int Rank { get; }
        [Required]
        public string RestaurantName { get; set; }
#nullable enable 
        public string? FavoriteDish { get; set; }
#nullable disable
        [Required]
        public string Address { get; set; }
        //phone number validation
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
#nullable enable
        public string? RestaurantPhone { get; set; }
#nullable disable
#nullable enable
        //if no website is entered we should store the default as coming soon 
        public string? LinkToWebsite { get; set; } = "Coming soon";
#nullable disable
        //creating array of top 5 restaurants 
        public static RestaurantList[] GetRestaurants()
        {
            RestaurantList r1 = new RestaurantList(1)
            {

                RestaurantName = "Maria Bonita Mexican Grill  ||",
                FavoriteDish = "Verde Chicken Enchiladas  ||",
                Address = "3815 167 W 800 N, Orem, UT 84057 ||",
                RestaurantPhone = "(801) 426-9328  ||",


            };
            RestaurantList r2 = new RestaurantList(2)
            {

                RestaurantName = "Chick Fil A  ||",
                FavoriteDish = "Chicken Nuggets w/ Chick Fil A Sauce  ||",
                Address = "484 Bulldog Ln ||",
                RestaurantPhone = "(801) 374-2697 ||",
                LinkToWebsite = "https://www.chick-fil-a.com/locations/ut/cougar-state"

            };
            RestaurantList r3 = new RestaurantList(3)
            {

                RestaurantName = "Communal ||",
                FavoriteDish = "Salad ||",
                Address = "102 N University Ave, Provo, UT 84601 ||",
                RestaurantPhone = "(801) 373-8000 ||",
                LinkToWebsite = "https://order.costavida.com/menu/costa-vida-provo"

            };
            RestaurantList r4 = new RestaurantList(4)
            {

                RestaurantName = "Blaze Pizza ||",
                FavoriteDish = "Build Your Own Pizza ||",
                Address = "1350 S State St, Orem, UT 84097 ||",
                RestaurantPhone = "(801) 528-9501 ||",
                LinkToWebsite = "https://order.costavida.com/menu/costa-vida-provo"
            };
            RestaurantList r5 = new RestaurantList(5)
            {

                RestaurantName = "Costa Vida ||",
                FavoriteDish = null,
                Address = "1200 N University Ave, Provo, UT 84606 ||",
                RestaurantPhone = "(801) 373 - 1876 ||",
                LinkToWebsite = "https://order.costavida.com/menu/costa-vida-provo"
            };
            return new RestaurantList[] { r1, r2, r3, r4, r5 };
        }
    }
}
