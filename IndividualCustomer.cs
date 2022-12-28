using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    public class IndividualCustomer : ObserverPerson
    {
        private int age;
        public int Age { get; set; }
        // private int quantity;
        // public int Quantity { get; set; }
        public IndividualCustomer(string name, string phone, string address, int age, int quantity)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Age = age;
            if (quantity <= 5) QuantityOfCustomer = quantity;
            else Console.WriteLine("Maximum of quantity is 5");
        }
        // public override void ShowInformation()
        // {
        //     System.Console.WriteLine("Here are Individual Customer Information: ");
        //     System.Console.WriteLine("Name: {0}, Phone: {1}, Address: {2}, Age{3}", Name, Phone, Address, Age);
        // }
        public override void Update(int quantityOfStore, string productName)
        {
            Console.Write("Hi {0}, ", Name);
            base.Update(quantityOfStore, productName);
        }
         public override void ShowInformation()
        {
            Console.WriteLine("Name: {0}, Phone: {1}", Name, Phone);
        }
         public override double CheckBill(Product product)
        {
            Console.WriteLine("{0, 45}", "Your bill");
            Console.Write    ("{0, 17}", "Customer");
            Console.WriteLine("{0, 50}", "Product \n");
            Console.Write    ("{0, 15}{1, 15}", "Name: ", Name);
            Console.WriteLine("{0, 40}{1}", "Name: ", product.Name);

            Console.Write    ("{0, 15}{1, 15}", "Phone: ", Phone);

            Console.Write    ("{0, 15}{1, 15}", "Address: ", Address);
            Console.WriteLine("{0, 40}{1}", "Price: $", product.Price);
            Console.Write    ("{0, 15}{1, 15}", "Quantity: ", QuantityOfCustomer);
            double total = product.Price * QuantityOfCustomer;
            Console.WriteLine("{0, 40}{1}", "Total money: $", total);
            
            Console.WriteLine("\nPlease confirm bill and pay (y/n) !!!");
            Console.Write    ("Your choice: ");

            char confirm = Convert.ToChar(Console.ReadLine());
            if (confirm == 'y') return total;
            return 0;
        }

    }
}