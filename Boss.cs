using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    public class Boss : ObserverPerson
    {
        // private string name;
        // public string Name { get; set; }
        // private string phone;
        // public string Phone { get; set; }
        // private string address;
        // public string Address { get; set; }
        private string position;
        public string Position { get; set; }
        public Boss(string name, string phone, string address) : base(name, phone, address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }
        public override void Update()
        {
            System.Console.WriteLine("There are some changes in your system.Please check it!");
        }
        public override void ShowInformation()
        {
        }
    }
}