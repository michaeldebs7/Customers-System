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
            while (true)
            {
                Console.WriteLine("What Do You Like To Order?");
                string input = Console.ReadLine();

                if (input == "menu")
                {
                    Program.GetMenu();

                }

                else
                {

                }
            }
            



            foreach(Item item in Items)
            {
                System.Console.WriteLine(item);
                ItemCount = Items.Length;
            }
        }
    }
}
