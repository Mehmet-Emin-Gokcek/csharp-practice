using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            List<MenuItem> menuList = new List<MenuItem>();


            Menu menu = new Menu(menuList);

            menu.AddItem(new MenuItem(250, "French Fries", Category.Appetizer, true));
            menu.AddItem(new MenuItem(150, "Rice Pudding", Category.Dessert, false));
            menu.AddItem(new MenuItem(1500, "Texas Steak", Category.Main_Course, true));
            menu.AddItem(new MenuItem(50, "Dinner Rolls", Category.Appetizer, false));
            menu.AddItem(new MenuItem(10, "Ice Tea", Category.Soft_Drink, true));

            MenuItem menuItem1 = new MenuItem(15, "Coca Cola", Category.Soft_Drink, true);
            Console.WriteLine(menuItem1);

            MenuItem menuItem2 = new MenuItem(15, "Coca Cola", Category.Soft_Drink, true);

            Console.WriteLine( $"Are below menu items the same?\n" +
                $"Menu Item 1: {menuItem1}" +
                $"Menu Item 2: {menuItem2}" +
                $"Answer: {menuItem1.Equals(menuItem2)}\n" +
                $"--------------------------------\n" );

            Console.WriteLine(menu);

            menu.RemoveItem(5);
            Console.WriteLine(menu);


        }
    }

}