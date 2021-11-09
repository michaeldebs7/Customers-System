namespace Customers_System
{
    class Item
    {
        public string ItemName;
        public int ItemPrice;
        public int ItemId;


        public Item(string itemName, int itemId, int itemPrice)
        {
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
            this.ItemId = itemId;
        }
    }
}
