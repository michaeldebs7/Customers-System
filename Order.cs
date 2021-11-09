using System.Collections.Generic;
using System;

namespace Customers_System
{
    class Order
    {
        public int OrderNumber;
        short OrderPrice;
        int ItemCount;
        public Order(int orderNumber, short orderPrice, int itemCount)
        {
            this.OrderNumber = orderNumber;
            this.OrderPrice = orderPrice;
            this.ItemCount = itemCount;
        }

        public void addOrder(params Item[] Items)
        {
            List<Item> OrderItems = new List<Item>();
            while (true)
            {
                if (Program.OrderEnded == true) break;
                Console.WriteLine("What Do You Like To Order?");
                string input = Console.ReadLine();

                if (input == "menu")
                {
                    Program.GetMenu();

                }

                else if(input == "done")
                {
                    Program.OrderEnded = true;
                    break;
                }

                else
                {
                    foreach(Item item in Menu.items)
                    {
                        if (input == item.ItemName)
	                    {
                            OrderItems.Add(item);
                        }
                    }
                }
            }
            



            foreach(Item item in OrderItems)
            {
                System.Console.WriteLine(item);
                ItemCount = OrderItems.Count;
            }
        }
    }
}
