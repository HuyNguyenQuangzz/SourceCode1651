using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    public abstract class ObserverPerson
    {
        private string name;
        public string Name { get; set; }
        private string phone;
        public string Phone { get; set; }
        private string address;
        public string Address { get; set; }
          // number of product for customer
        protected int quantityOfCustomer;
        public int QuantityOfCustomer
        {get { return quantityOfCustomer;}
            set
            {
                if (value < 0) Console.WriteLine("Quantity must >= 0");
                else quantityOfCustomer = value;
            }
            
        }

        // protected Product data;
        // public ObserverPerson(Product data)
        // {
        //     this.data = data;
        // }
        // public ObserverPerson(string name, string phone, string address)
        // {
        //     Name = name;
        //     Phone = phone;
        //     Address = address;
        // }

        private bool status;
        public bool Status { get; set; }
        public abstract double CheckBill(Product product);
        public virtual void Update(int quantityOfStore, string productName)
        {
            if (quantityOfStore <= 0)
            {
                Console.WriteLine("{0} is currently not available right now, please come back later", productName);
                System.Console.WriteLine();
                status = false;
            }
            else if (quantityOfStore < QuantityOfCustomer)
            {
                Console.WriteLine("{0} is not enough for you", productName);
                status = false;
            } 
            else
            {
                status = true;
                Console.WriteLine("{0} are currently available.Please take products and payment!", productName);
            }
        }
         public int Payment(Product product)
        {
            if (Status)
            {
                double total = CheckBill(product);
                if (total == 0) return 0;
                System.Console.WriteLine("Please enter monney($): ");
                double payment = double.Parse(Console.ReadLine());
                if (payment >= total) 
                {
                    int temp = QuantityOfCustomer;
                    QuantityOfCustomer = 0;
                    if (payment == total) Console.WriteLine("Payment successful");
                    else Console.WriteLine("Give change ${0}", (payment - total));
                    return temp;
                }
                else Console.WriteLine("Payment failed !!!");
            } 
            else Console.WriteLine("{0} is not available !!!", product.Name);
            return 0;
        }
        public abstract void ShowInformation();
    }
}