using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    public class Product
    {
        private string name;
        public string Name { get; set; }
        private double price;
        public double Price { get; set; }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
        }
        private List<ObserverPerson> persons;
         public List<ObserverPerson> Persons 
        {
            get { return persons; }
        }
        // private List<Product> products;
        // public List<Product> Products
        // {
        //     get { return products; }
        // }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            // Quantity = quantity;
            // products = new List<Product>();
            persons = new List<ObserverPerson>();
        }
        public bool Update(int quantity)
        {
            if (quantity >= 0) 
            {
                this.quantity = quantity;
                if (quantity > 0) 
                {
                    Notifycation();
                }
                return true;
            }
            else Console.WriteLine("Data invalid. Please try again!");
            return false;
        }
        public void Attach(ObserverPerson person)   // as Register takes notifications for customers
        {
            persons.Add(person);
            System.Console.WriteLine("Congratulation.You have successfully signed up to receive notifications!");
            System.Console.WriteLine();
        }
        public void Detach()  // as Remove takes notifications for customers
        {
            int i = 0;
            foreach(ObserverPerson p in persons)
            {
                i = i + 1;
                Console.Write("{0}. ", i);
                p.ShowInformation();
            }
            // int choice = CheckValidInteger("Choose customer: ", 1, i);
            System.Console.Write("Please select the ID of the customer you want to remove from the notification list: ");
            int choice = int.Parse(System.Console.ReadLine());
            persons.RemoveAt(i - 1);
            // persons.Remove(person);
            System.Console.WriteLine("Remove Customer Successfully ");
            System.Console.WriteLine();
        }
        public void Notifycation()
        {
            foreach (ObserverPerson person in persons)
            {
                person.Update(Quantity, Name);
            }
        }
        
        // public void ChangeQuantityProduct(int quantity)
        // {
        //     Quantity += quantity;
        //     Notifycation(); // notify to observers, tell them to update new data
        // }
        public void ShowInformation()
        {
            // System.Console.WriteLine("=============================================================");
            // System.Console.WriteLine("|---------Name---------Price-----------Quantity-------------");                            
            System.Console.WriteLine("Name: {0}, Price: {1}, Quantity: {2}", Name,Price, Quantity);
        }
    
    }
}