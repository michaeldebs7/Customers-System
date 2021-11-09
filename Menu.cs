using System.Collections.Generic;
namespace Customers_System
{
    class Menu
    {
        

        public static readonly List<Item> items = new List<Item>();

        public void addItems(string ItemName, int ItemPrice, int ItemId)
        {

            Item NewItem = new Item(ItemName, ItemId, ItemPrice);
            items.Add(NewItem);
        }

        public void removeItems(string itemName)
        {

        }

        public void getItem()
        {

        }

        void FindItem(string itemName)
        {

        }
    }
}
