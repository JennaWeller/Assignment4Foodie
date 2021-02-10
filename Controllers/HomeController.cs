using Assignment4Foodie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4Foodie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach (RestaurantList r in RestaurantList.GetRestaurants())
            {
                //if the favorite dish is empty, then you list "It's all tasty" and handling the nulls with ?
#nullable enable
                string? FavoriteDish = r.FavoriteDish ?? "It's all tasty! ||";
                string? RestaurantPhone = r.RestaurantPhone;
                string? LinkToWebsite = r.LinkToWebsite;

#nullable disable
                //pass in favoritedish instead of r. because we are giving it a value of it's all tasty if it ends up null 
                restaurantList.Add(string.Format("#{0}: {1} {2} {3} {4} {5} ", r.Rank, r.RestaurantName, FavoriteDish, r.Address, RestaurantPhone, LinkToWebsite));

            }
            return View(restaurantList);
        }
        [HttpGet]
        public IActionResult AddRestaurant()
        {
            return View();
        }
        [HttpPost]
        //adding the restaurants to the storage list and returning to the output page 
        public IActionResult AddRestaurant(RestaurantResponse restaurantResponse)
        {   //adding the values from the form into storage
            TempStorage.AddRestaurant(restaurantResponse);
            return View("RestaurantOutput", restaurantResponse);
        }
        //returning the view of the suggestions inputted by users 
        public IActionResult RestaurantSuggestions()
        {
            return View(TempStorage.Restaurant);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

