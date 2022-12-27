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
         public BusinessCustomer(string name, string phone, string address) : base(name, phone, address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }
        public override void ShowInformation()
        {
            System.Console.WriteLine("Information of Business Customer: ");
            System.Console.WriteLine("Name: {0}, Phone: {1}, Address{2}", Name, Phone, Address);
        }
        public override void Update()
        {
            System.Console.WriteLine("The product has been available. Please take and purchase it!");
        }
    }
}