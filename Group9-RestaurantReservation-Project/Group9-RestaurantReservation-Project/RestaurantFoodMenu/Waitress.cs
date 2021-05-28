using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.FoodMenu;
using System;
using System.Collections.Generic;

namespace FoodDeliveryApp.RestaurantFoodMenu
{
    public class Waitress
    {
        private readonly string restaurantId;
        FoodMenu foodMenu;
        public Waitress(string restaurantId)
        {
            this.restaurantId = restaurantId;
        }

        public List<FoodMenuModel> PrintFoodMenu()
        {
            foodMenu = new FoodMenu(restaurantId);
            IIterator restaurantFoodMenu = foodMenu.CreateFoodMenuIterator();
            return PrintFoodMenu(restaurantFoodMenu);
        }

        private List<FoodMenuModel> PrintFoodMenu(IIterator iterator)
        {
            Console.WriteLine("Table List");
            Console.WriteLine("**************************************");
            Console.WriteLine();

            List<FoodMenuModel> foodMenu = new List<FoodMenuModel>();

            while (iterator.HasNext())
            {
                FoodMenuModel foodMenuItem = (FoodMenuModel)iterator.Next();
                foodMenu.Add(foodMenuItem);

                Console.WriteLine("Restaurant ID : {0}", foodMenuItem.RestaurantId);
                Console.WriteLine("Table ID : {0}", foodMenuItem.FoodId);

                Console.WriteLine("Number of Seat : {0}", foodMenuItem.Cuisine);
                Console.WriteLine("Table Status : {0}", foodMenuItem.FoodName);
             
                Console.WriteLine("____________________________");
                Console.WriteLine();
            }

            return foodMenu;
        }
    }
}
