using FoodDeliveryApp.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryApp.FoodDeliveryDriver
{
    public class MealSelectorDriver
    {
        public List<FoodMenuModel> MealSelectionbyUser(List<FoodMenuModel> foodMenu)
        {
            //Meal Selector.

            Console.WriteLine(string.Empty);
            Console.WriteLine("Please select the Table Id");
            Console.WriteLine("_________________________");

            List<FoodMenuModel> selectedMealItems = new List<FoodMenuModel>();
            char answer;
            do
            {
                Console.WriteLine("Enter Table Id:");
                var foodId = Console.ReadLine();
                var foodItem = foodMenu.FirstOrDefault(e => e.FoodId == foodId);
                if (foodItem != null)
                {
                    Console.WriteLine("You Selected Below Table:");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Table ID: {0}", foodItem.FoodId);
                    Console.WriteLine("Number of Seat: {0}", foodItem.Cuisine);
                    //Console.WriteLine("Rate(Rs.): {0}", foodItem.Rate);
                    //Console.WriteLine("Rating: {0}", foodItem.Rating);
                    selectedMealItems.Add(foodItem);
                }
                else
                    Console.WriteLine("Invalid Table Id Selected. No Table available with this Id.");

                Console.WriteLine(string.Empty);

                Console.WriteLine("Do you want to add more Table(y/n):...?");
                answer = Console.ReadKey().KeyChar;
                Console.WriteLine(string.Empty);

            } while (answer != 'n');

            return selectedMealItems;
        }
    }
}
