using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        private int price { set; get; }
        private String description { set; get; }
        private String category { set; get; }
        private Boolean novelItem { set; get; }

        public MenuItem(int price, string description, string category, bool novelItem)
        {
            this.price = price;
            this.description = description;
            this.category = category;
            this.novelItem = novelItem;
        }
    }
}