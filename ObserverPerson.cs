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
        protected Product data;
        public ObserverPerson(Product data)
        {
            this.data = data;
        }
        public ObserverPerson(string name, string phone, string address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }
        public abstract void Update();
        public abstract void ShowInformation();
    }
}