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
        public IndividualCustomer(string name, string phone, string address,int age) : base(name, phone, address)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Age = age;
        }
        public override void ShowInformation()
        {
            System.Console.WriteLine("Here are Individual Customer Information: ");
            System.Console.WriteLine("Name: {0}, Phone: {1}, Address: {2}, Age{3}", Name, Phone, Address, Age);
        }
        public override void Update()
        {
            System.Console.WriteLine("Your product has been available. Please take and purchase it!");
        }
    }
}