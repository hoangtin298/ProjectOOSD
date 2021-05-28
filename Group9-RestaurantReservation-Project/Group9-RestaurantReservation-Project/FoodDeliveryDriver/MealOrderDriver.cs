﻿using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.OrderAndCancellation;
using System;
using System.Collections.Generic;

namespace FoodDeliveryApp.FoodDeliveryDriver
{
    public class MealOrderDriver
    {
        /// <summary>
        /// This driver called Command Design Pattern
        /// </summary>
        /// <param name="selectedMealItems"></param>
        /// <param name="totalCost"></param>
        /// <param name="restaurantId"></param>
        /// <param name="orderId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public char MealOrderByUser(List<FoodMenuModel> selectedMealItems, double totalCost, string restaurantId, out string orderId, out UserModel user)
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine("Do you want to place order(y/n)...?");
            var wantsOrder = Console.ReadKey().KeyChar;
            Console.WriteLine(string.Empty);

            orderId = string.Empty;
            user = null;

            if (wantsOrder == 'y')
            {
                Console.WriteLine("_________________________");
                Food food = new Food();
                OrderFood orderFood = new OrderFood(food);
                orderFood.FoodItems = selectedMealItems;
                orderFood.User = new UserModel();
                orderFood.User.UserId = "18110013";
                orderFood.User.UserName = "Bui Trung Hieu";
                orderFood.User.Address = "10/9, phuong Binh Tho, Thanh Pho Thu Duc";
                orderFood.User.PhoneNumber = "0975770921";
                //orderFood.User.Amount = totalCost;
                orderFood.RestaurantId = restaurantId;
                user = orderFood.User;
                Customer customer = new Customer();
                customer.TakeOrder(orderFood);
                customer.PlaceOrders();
                orderId = orderFood.OrderId;
                Console.WriteLine(string.Empty);
            }

            //Order Cancellation.
            char cancel = 'n';
            if (!string.IsNullOrEmpty(orderId))
            {
                Console.WriteLine("Do you want to cancel order(y/n)...?");
                cancel = Console.ReadKey().KeyChar;
                Console.WriteLine(string.Empty);

                if (cancel == 'y')
                {
                    Console.WriteLine(String.Empty);
                    Food food = new Food();
                    CancelFood cancelOrder = new CancelFood(food);
                    cancelOrder.OrderId = orderId;
                    Customer customer = new Customer();
                    customer.TakeOrder(cancelOrder);
                    customer.PlaceOrders();
                }
            }

            return cancel;
        }
    }
}
