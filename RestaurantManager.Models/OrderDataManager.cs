using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {       
        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
        }

        // Module 1
        public List<MenuItem> MenuItems { get; set; }
        // module 1
        public List<MenuItem> CurrentlySelectedMenuItems { get; set; }
    }
}
