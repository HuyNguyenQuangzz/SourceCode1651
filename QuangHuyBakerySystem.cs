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
            System.Console.WriteLine("|----Wellcome to Quang Huy Bakery Management System ----|");
            System.Console.WriteLine("|----------------1. Add new Product---------------------|");
            System.Console.WriteLine("|----------------2. Update Product----------------------|");
            System.Console.WriteLine("|----------------3. Show all information about Product--|");
            System.Console.WriteLine("|----------------4. Services For Person-----------------|");
            System.Console.WriteLine("|----------------0. Exit--------------------------------|");
            System.Console.WriteLine("|_______________________________________________________|");
        }

        private int GetChoice()
        {
            int choice;
            try
            {
                System.Console.Write("Enter your choice: ");
                 choice = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine();
                
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Invalid value. Please try again!");
            }
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
                        System.Console.WriteLine("There are no products available!");
                        System.Console.WriteLine("Please enter one or more products to use this option");
                    }
                    break;
                case 3:
                    if (products.Count > 0)
                    {
                        ShowAllProduct();
                    }
                    else
                    {
                        System.Console.WriteLine("There are no products available to show!");
                        System.Console.WriteLine("Please enter one or more products!");
                    }
                    break;
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
                    else Console.WriteLine("You must have at least 1 product!\nSo, please come back to add new products");
                    break;
                // Services(); break;
                case 0: Exit(); break;
                default: System.Console.WriteLine("Invalid Option. Please try again!"); break;
            }
        }

        private void AddNewProduct()
        {
            System.Console.WriteLine("Enter information about the new product");
            System.Console.Write("Enter Product's Name: ");
            string name = System.Console.ReadLine();
            System.Console.Write("Enter Product's Price($): ");
            double price = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine();

            // Product x = new Product(name, price);
            // products.Add(x);
            products.Add(new Product(name, price));

        }
        private void UpdateProduct()
        {
            int i = ShowAllProduct();
            System.Console.Write("Please enter ID product you want to update: ");
            int choice = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine();
            System.Console.WriteLine("What information about product you want to update? ");
            System.Console.WriteLine("1. Update all information about Product");
            System.Console.WriteLine("2. Update only Quantity of Product");
            System.Console.Write("Enter your choice: ");
            int input = int.Parse(System.Console.ReadLine());
            if (input == 1)
            {
                System.Console.Write("Enter new Product's Name: ");
                products[choice - 1].Name = System.Console.ReadLine();
                System.Console.Write("Enter new Price: ");
                products[choice - 1].Price = double.Parse(System.Console.ReadLine());
                System.Console.Write("Enter new Quantity: ");
                System.Console.WriteLine();
            }
            else
            {
                System.Console.Write("Enter Product's Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                products[choice - 1].Update(quantity);
                System.Console.WriteLine();
            }
        }
        private int ShowAllProduct()
        {
            int i = 0;
            System.Console.WriteLine("|---------------------Here are all products---------------------|");

            foreach (Product p in products)
            {
                i = i + 1;
                System.Console.Write("|ID|{0}. ", i);
                p.ShowInformation();
            }
            // System.Console.WriteLine("|_______________________________________________________________|");
            System.Console.WriteLine();
            return i;
        }
        private int Services()
        {
            Console.WriteLine("|--------------------------Here are list services for customer-------------------|");
            Console.WriteLine("|1. Customers Register to receive notifications when products are available      |");
            Console.WriteLine("|2. Remove Customers from notification list                                      |");
            Console.WriteLine("|3. Print all list of customers receiving notifications                          |");
            Console.WriteLine("|4. Payment for registered product                                               |");
            Console.WriteLine("|0. Back                                                                         |");
            Console.WriteLine("|________________________________________________________________________________|");
            System.Console.Write("|  Please enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            return choice;
        }
        public void DoServices(int choice)
        {
            switch (choice)
            {
                case 1: RegisterCustomer(); break;
                case 2: RemoveCustomer(); break;
                case 3: PrintAllNotification(); break;
                case 4: Purchase(); break;
                case 0: System.Console.WriteLine("Back successful!"); break;
                default: Console.WriteLine("Invalid Options!"); break;
            }
        }
        private void inputInformation()
        {
            System.Console.WriteLine("Please provide complete information about yourself!");
            System.Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();
            System.Console.Write("Enter Address: ");
            string address = Console.ReadLine();
        }
        private void RegisterCustomer()
        {
            int i = ShowAllProduct();
            System.Console.Write("Enter ID what product you want to register: ");
            int product = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.WriteLine("Who you are?");
            System.Console.WriteLine("1. Individual Customer");
            System.Console.WriteLine("2. Business Customer");
            System.Console.WriteLine("3. Boss");
            System.Console.Write("Your choice:");
            int answer = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.WriteLine("Please provide complete information about yourself!");
            System.Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();
            System.Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            if (answer == 1)
            {
                System.Console.Write("Enter your Age: ");
                int age = int.Parse(Console.ReadLine());
                System.Console.Write("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                IndividualCustomer ic = new IndividualCustomer(name, phone, address, age, quantity);
                System.Console.WriteLine();
                products[answer - 1].Attach(ic);
            }
            else if (answer == 2)
            {
                // inputInformation();
                System.Console.Write("Enter Email: ");
                string email = Console.ReadLine();
                System.Console.Write("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                BusinessCustomer bc = new BusinessCustomer(name, phone, address, email, quantity);
                products[answer - 1].Attach(bc);
            }
            else if (answer == 3)
            {
                // inputInformation();
                System.Console.Write("Enter Position: ");
                string position = Console.ReadLine();
                Boss b = new Boss(name, phone, address, position);
                products[answer - 1].Attach(b);
            }
            else
            {
                System.Console.WriteLine("Invalid value. Please try again!!!");
            }
        }
        private void RemoveCustomer()
        {
            int i = ShowAllProduct();
            // int device = CheckValidInteger("Enter your choice: ", MIN_LIST, i);
            // if (devices[device - 1].Customers.Count > 0) devices[device - 1].RemoveCustomer();
            // else Console.WriteLine("Please add 1 customer !!!");

            System.Console.Write("Select the ID of the product you want to remove who has signed up for notifications: ");
            int answer = int.Parse(Console.ReadLine());
            if (products[answer - 1].Persons.Count > 0) products[answer - 1].Detach();
            else Console.WriteLine("Please add 1 customer !!!");
        }
        private void PrintAllNotification()
        {
            int i = ShowAllProduct();
            System.Console.Write("Select the ID of the product you want to see who has signed up for notifications: ");
            int answer = int.Parse(Console.ReadLine());


            if (products[answer - 1].Persons.Count > 0)
            {
                products[answer - 1].Notifycation();
            }
            else
            {
                Console.WriteLine("This product does not have anyone subscribed to receive notifications!");
                Console.WriteLine("Please view other products or register a new customer!");
            }
            System.Console.WriteLine();
        }
        private void Purchase()
        {
            // int i = ShowAllProduct();
            // System.Console.Write("Enter the number of product you want to payment: ");
            // int answer = int.Parse(Console.ReadLine());

            // if (products[answer - 1].Customers.Count > 0)
            // {
            //     products[answer - 1].PrintStatusForAllCustomer();
            //     int customerCount = products[answer - 1].Customers.Count;

            //     System.Console.Write("Enter customer's ID: ");
            //     int customer = int.Parse(Console.ReadLine());
            //     // int customer = CheckValidInteger("Id customer: ", 1, customerCount);

            //     products[answer - 1].Persons[customer - 1].Update(products[answer - 1].Quantity, products[answer - 1].Name);
            //     int update = products[answer - 1].Persons[customer - 1].Pay(products[answer - 1]);
            //     products[answer - 1].Update(products[answer - 1].Quantity - update);
            // }
            // else Console.WriteLine("Please add 1 customer !!!");
        }
        private void Exit()
        {
            System.Console.WriteLine("                                                      Thank you so much !!!");
            System.Console.WriteLine("                                                 Goodbye! See you in the next time!");
        }
    }
}