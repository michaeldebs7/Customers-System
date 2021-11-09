using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers_System
{
    class Program
    {
        public static void GetMenu()
        {
            foreach(Item item in Menu.items)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            int OrderNumber = 0;

            while (true)
            {
                Console.Write("Enter Command: ");
                string command = Console.ReadLine();


                if(command == "add order")
                {
                    OrderNumber++;
                    int CustomerNumber;
                    while (true)
                    {
                        Console.WriteLine("Old Customer Or New Customer? Answer With old, new");
                        string input = Console.ReadLine();

                        if (input == "old")
                        {
                            bool FoundCustomer = false;
                            Console.Write("Enter Phone Number: ");
                            CustomerNumber = Convert.ToInt32(Console.ReadLine());

                            Customer SelectedCusetomer;

                            foreach(Customer customer in customers)
                            {
                                if(customer.PhoneNumber == CustomerNumber)
                                {
                                    FoundCustomer = true;
                                    Console.WriteLine("Customer Verified!!");
                                    Console.WriteLine(customer.Name);
                                    Console.WriteLine(customer.id);
                                    Console.WriteLine(customer.PhoneNumber);

                                    SelectedCusetomer = customer;

                                    Console.WriteLine("Please Conferm.");
                                    string Input = Console.ReadLine();

                                    if (Input == "confermed")
                                    {
                                        SelectedCusetomer.NewOrder(OrderNumber);
                                    }

                                    else 
                                    {
                                        OrderNumber--;
                                        break;
                                    }
                                }
                            }
                            if(FoundCustomer == true)
                            {

                            }

                            else if(FoundCustomer == false)
                            {
                                Console.WriteLine("Did Not Find Any Costumer With That Name.");
                                break;
                            }
                            
                        }

                        else if (input == "new")
                        {
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Unknown Command!!");
                        }
                    }
                }

                else if(command == "exit")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Wrong Command!!");
                }
            }



            Console.ReadKey();
        }

    }
}
