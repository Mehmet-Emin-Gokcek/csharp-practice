using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {

        private DateTime lastUpdate { set; get; }
        private List<MenuItem> items { set; get; }


        public Menu(List<MenuItem> Items)
        {
            lastUpdate = DateTime.Now;
            items = Items;
        }

        public void AddItem(MenuItem menuItem)
        {
            items.Add(menuItem);
        }

        public void RemoveItem(int index)
        {
            items.RemoveAt(index - 1);
        }

        public Boolean isNew(MenuItem menuItem)
        {
            return menuItem.NovelItem;
        }

        public override string ToString()
        { 
          String item = null;
          int index = 1;

            foreach (MenuItem menuItem in items)
            {
                item = item + "Menu Item " + index + ": " + menuItem.ToString();
                index++;
            }

            return "Here is the Most Recent Menu\n" + "-------------------------\n" +
                "Menu: [ " + "Last Update: " + lastUpdate + ",  \n" + item + " ]\n";
        }
    }
}
