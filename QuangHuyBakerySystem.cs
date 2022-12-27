using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    public class QuangHuyBakerySystem
    {
        private const int EXIT = 0;
        private const int BACK = 0;
        private List<Product> products;
        public QuangHuyBakerySystem()
        {
            products = new List<Product>();
        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                Process(choice);
                if (choice == EXIT) running = false;
            }
        }

        private void PrintMenu()
        {
            System.Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            System.Console.WriteLine("|--------Wellcome to X System Management----------------|");
            System.Console.WriteLine("|----------------1. Add new Product---------------------|");
            System.Console.WriteLine("|----------------2. Update Product----------------------|");
            System.Console.WriteLine("|----------------3. Show all information about Product--|");
            System.Console.WriteLine("|----------------4. Services For Person-----------------|");
            System.Console.WriteLine("|----------------0. Exit--------------------------------|");
            System.Console.WriteLine("|_______________________________________________________|");
        }

        private int GetChoice()
        {
            System.Console.Write("Enter your choice: ");
            int choice = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine();
            return choice;
        }

        private void Process(int choice)
        {
            switch (choice)
            {
                case 1: AddNewProduct(); break;
                case 2:
                    if (products.Count > 0)
                    {
                        UpdateProduct();
                    }
                    else
                    {
                        System.Console.WriteLine("Please enter one or more products to use this");
                    }
                    break;
                case 3: ShowAllProduct(); break;
                case 4:
                    if (products.Count > 0)
                    {
                        bool run = true;
                        while (run)
                        {
                            int select = Services();
                            DoServices(select);
                            if (select == BACK) run = false;
                        }
                    }
                    else Console.WriteLine("Please enter 1 device !!!");
                    break;
                // Services(); break;
                case 0: Exit(); break;
                default: System.Console.WriteLine("Invalid Option. Please try again!"); break;
            }
        }

        private void AddNewProduct()
        {
            System.Console.WriteLine("Enter information about the new product");
            System.Console.WriteLine("Enter Product's Name: ");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Enter Product's Price: ");
            double price = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine();

            // Product x = new Product(name, price);
            // products.Add(x);
            products.Add(new Product(name, price));

        }
        private void UpdateProduct()
        {
            int i = ShowAllProduct();
            int choice = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("1. Update all\n2.Update Quantity\nYour choice: ");
            int update = int.Parse(System.Console.ReadLine());
            if (update == 1)
            {
                products[choice - 1].Name = System.Console.WriteLine("Enter Product Name: ");
                products[choice - 1].Price = double.Parse(System.Console.ReadLine());
            }
            int quantity = int.Parse(Console.ReadLine());
            products[choice - 1].setStatus(quantity);
        }
        private void ShowAllProduct()
        {
            int i = 0;
            foreach (Product p in products)
            {
                i = i + 1;
                Console.Write("{0}. ", i);
                p.PrintInformation();
            }
            return i;
        }
        private void Services()
        {
            Console.WriteLine("-----Here are list services for customer----- ");
            Console.WriteLine("1. Register to receive notifications when cake available");
            Console.WriteLine("2. Remove from notification list");
            Console.WriteLine("3. Print all Notification");
            Console.WriteLine("4. Purchase");
            Console.WriteLine("0. Back");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public void DoServices()
        {
            // switch(choice)
            // {
            //     case REGISTER: RegisterCustomer(); break;
            //     case REMOVE  : RemoveCustomer();   break;
            //     case PRINT_NOTIFICATION: PrintAllNotification(); break;
            //     case PURCHASE: Purchase(); break;
            //     case BACK: break; 
            //     default: Console.WriteLine("Invalid !!!"); break;
            // }
         }
        private void Exit()
        {
            System.Console.WriteLine("Thank you so much !!!");
            System.Console.WriteLine("Goodbye! See you in the next time!");
        }
    }
}