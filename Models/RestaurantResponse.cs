using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment4Foodie.Models
{
    public class RestaurantResponse
    {   //this is linked to the form , getting and setting the values from it
        [Required(ErrorMessage = "Error:Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Error:Please enter a restaurant name")]
        public string RestaurantName { get; set; }
        [Required(ErrorMessage = "Error:Please enter a favorite dish")]
        public string FavoriteDish { get; set; }
        //validation for phone numbers
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        public string RestaurantPhone { get; set; }

    }
}


