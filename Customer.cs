using System.Collections.Generic;

namespace Customers_System
{
    class Customer
    {
        public string Name;
        public int id;
        public short PhoneNumber;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(string name, int id, short phoneNumber)
        {
            this.Name = name;
            this.id = id;
            this.PhoneNumber = phoneNumber;
        }

        
        short OrderPrice;
        int ItemCount;
        Item Item;
        public void NewOrder(int orderNumber)
        {
            Order NewOrder = new Order(orderNumber, OrderPrice, ItemCount);
            System.Console.WriteLine("Order Number: " + NewOrder.OrderNumber);

           

            NewOrder.addOrder(Item);

            Orders.Add(NewOrder);
        }

        public void PreviousOrders()
        {
            foreach(Order order in Orders)
            {
                System.Console.WriteLine(order);
            }
        }
    }
}
