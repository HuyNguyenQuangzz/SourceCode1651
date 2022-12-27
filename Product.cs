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
        private List<Product> products;
        public List<Product> Products
        {
            get { return products; }
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            // Quantity = quantity;
            // products = new List<Product>();
            persons = new List<ObserverPerson>();
        }
        public bool setStatus(int quantity)
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
        public void Attach(ObserverPerson person)
        {
            persons.Add(person);
            System.Console.WriteLine("Add Customer Successfully ");
        }
        public void Detach(ObserverPerson person)
        {
            persons.Remove(person);
            System.Console.WriteLine("Remove Customer Successfully ");
        }
        public void Notifycation()
        {
            foreach (ObserverPerson person in observers)
            {
                person.Update();
            }
        }
        // public void ChangeQuantityProduct(int quantity)
        // {
        //     Quantity += quantity;
        //     Notifycation(); // notify to observers, tell them to update new data
        // }
        public void PrintInformation()
        {
            Console.WriteLine("Name: {0},Price: {1}, Quantity: {2}", Name,Price, Quantity);
        }
    
    }
}