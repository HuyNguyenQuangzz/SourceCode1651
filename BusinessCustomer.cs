using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    public class BusinessCustomer : ObserverPerson
    {
        // private string businessName;
        // public string BusinessName { get; set; }
        // private string businessPhone;
        // public string BusinessPhone { get; set; }
        // private string businessAddress;
        // public string BusinessAddress { get; set; }
        // public BusinessCustomer(tring businessName, string businessPhone, string businessAddress) : base(businessName, businessPhone, businessAddress
        // {
        //     BusinessName = businessName;
        //     BusinessPhone = businessPhone;
        //     BusinessAddress = businessAddress;
        // }
        private string email;
        public string Email { get; set; }
         public BusinessCustomer(string name, string phone, string address, string email, int quantity)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Email = email;
            QuantityOfCustomer = quantity;
        }
        public override void ShowInformation()
        {
            System.Console.WriteLine("Information of Business Customer: ");
            Console.WriteLine("Name: {0}, Phone: {1}", Name, Phone);

            // System.Console.WriteLine("Name: {0}, Phone: {1}, Address{2}, Email{3}", Name, Phone, Address, Email);
        }
        public override void Update(int quantityOfStore, string productName)
        {
            Console.Write("Hi {0}, ", Name);
            base.Update(quantityOfStore, productName);
        }
        public override double CheckBill(Product product)
        {
            Console.WriteLine("{0, 50}", "Your bill");
            Console.Write    ("{0, 17}", "Business");
            Console.WriteLine("{0, 45}", "Device \n");
            Console.Write    ("{0, 20}{1, 15}", "Corporate name: ", Name);
            Console.WriteLine("{0, 30}{1}", "Name: ", product.Name);
            Console.Write    ("{0, 20}{1, 15}", "Phone: ", Phone);
            Console.Write    ("{0, 20}{1, 15}", "Address: ", Address);
            Console.Write    ("{0, 20}{1, 15}", "Quantity: ", QuantityOfCustomer);
            Console.WriteLine("{0, 30}{1}", "Price: $", product.Price);
            double total = product.Price * QuantityOfCustomer;
            Console.WriteLine("{0, 20}{1, 15}", "Total money: $", total);
            
            Console.WriteLine("\nPlease confirm bill and pay (y/n) !!!");
            Console.Write    ("Your choice: ");

            char confirm = Convert.ToChar(Console.ReadLine());
            if (confirm == 'y') return total;
            return 0;
        }
    }
}