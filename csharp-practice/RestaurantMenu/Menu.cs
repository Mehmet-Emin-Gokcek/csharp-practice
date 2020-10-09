using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {

        private DateTime lastUpdate { set; get; }
        private List<MenuItem> items { set; get; }


        public Menu(DateTime lastUpdate, List<MenuItem> items)
        {
            this.lastUpdate = lastUpdate;
            this.items = items;
        }
    }
}
