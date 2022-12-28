using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    public class Boss : ObserverPerson
    {
        private string position;
        public string Position { get; set; }
        public Boss(string name, string phone, string address, string position)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Position = position;
        }
        public override void Update(int quantityOfStore, string productName)
        {
            Console.Write("Hello Boss {0}, ", Name);
            base.Update(quantityOfStore, productName);
        }
        public override void ShowInformation()
        {
        }
        public override double CheckBill(Product product)
        {return 0;}
    }
}