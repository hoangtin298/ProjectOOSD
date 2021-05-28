using FoodDeliveryApp.FoodDeliveryAppModel;
using System.Collections.Generic;

namespace FoodDeliveryApp.RestaurantWebService
{
    public class FoodMenuService
    {
        public FoodMenuService(string endPoint, string restaurantId)
        {
            //Initialize web service with the endpoint string.
            //Data for food Menu items will fetch based on the Restaurant Id.
        }

        public List<FoodMenuModel> getAllFoodMenu(string restaurantId)
        {
            List<FoodMenuModel> foodMenu = new List<FoodMenuModel>();
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "001", Cuisine = "4", FoodName = "Free" , Rating = 5, Rate = 250});
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "002", Cuisine = "2", FoodName = "Free", Rating = 4, Rate = 300 });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "003", Cuisine = "10", FoodName = "Free", Rating = 5, Rate = 250 });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "004", Cuisine = "20", FoodName = "Free", Rating = 3, Rate = 250 });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "005", Cuisine = "2", FoodName = "Free", Rating = 5, Rate = 100 });

            return foodMenu;
        }
    }
}
