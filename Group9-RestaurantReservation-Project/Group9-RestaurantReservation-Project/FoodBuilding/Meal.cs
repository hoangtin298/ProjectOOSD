using FoodDeliveryApp.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;

namespace FoodDeliveryApp.Ordering
{
    public class Meal
    {
        private readonly List<FoodMenuModel> foodItems = new List<FoodMenuModel>();

        public void AddFoodItem(List<FoodMenuModel> items)
        {
            foodItems.AddRange(items);
        }

        public double GetCost()
        {
            double cost = 0;

            foreach (var item in foodItems)
            {
                cost += item.Rate;
            }

            return cost;
        }

        public void ShowItems()
        {
            foreach (var item in foodItems)
            {
                Console.WriteLine("Table Id: {0}", item.FoodId);
                //Console.WriteLine("Food Name: {0}", item.FoodName);
                Console.WriteLine("Number of seat: {0}", item.Cuisine);
                Console.WriteLine("Table Status: {0}", item.FoodName);
                Console.WriteLine("----------------------------");
            }
        }
    }
}
