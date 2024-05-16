namespace Chapter4Studio;

using System;

    public class Menu
    {
        public DateTime LastUpdated { get; }
        public List<MenuItem> Items { get; set; }

        public Menu(DateTime dateUpdated, List<MenuItem> item)
        {
            LastUpdated = dateUpdated;
            Items = item;
        }

        //Add new menu items 
        //Remove menu items 
        //Print LastUpdated Value 
        //Print Full Menu
    }

