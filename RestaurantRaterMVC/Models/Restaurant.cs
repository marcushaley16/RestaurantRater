using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRaterMVC.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }
        public int RestaurantRating { get; set; }
    }

    public class RestaurantDBContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}