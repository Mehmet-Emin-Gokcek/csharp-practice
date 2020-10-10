using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {

        public int Price { set; get; }
        public String Description { set; get; }
        public Category Category { set; get; }
        public Boolean NovelItem { set; get; }

        public MenuItem(int price, string description, Category category, bool novelItem)
        {
            Price = price;
            Description = description;
            Category = category;
            NovelItem = novelItem;
        }
  

        public override string ToString()
        {
            return "{ Price: " + Price + ", Description: " + Description + ", Category: " + Category + ", New Item: " + NovelItem + " }\n"  ;
        }

    

        public override bool Equals(Object obj)
        {
            // Perform an equality check on two rectangles (Point object pairs).
            if ((obj == null) || !base.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            else
            {
                MenuItem objItem = (MenuItem)obj;

                return Price.Equals(objItem.Price) &&
                            Description.Equals(objItem.Description) &&
                            Category.Equals(objItem.Category) &&
                            NovelItem.Equals(objItem.NovelItem);
            }
        }
        


    }

    public enum Category
    {
        Appetizer,
        Main_Course,
        Dessert,
        Soft_Drink,
    }
}