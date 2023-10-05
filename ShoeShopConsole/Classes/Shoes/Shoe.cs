using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Classes.Shoes
{
    internal abstract class Shoe : IShoe
    {
        protected uint _id;
        protected string _name;
        protected string _brand;
        protected decimal _price;
        public abstract uint Id { get; set; }
        public string Name { get { return _name; } }
        public string Brand { get { return _brand; } }
        public decimal Price { get { return _price; } }

        public Shoe(string name, string brand, decimal price)
        {
            _name = name;
            _brand = brand;
            _price = price;
        }

        public abstract void Show();
        public abstract string ToString();
        public override bool Equals(object obj)
        {
            if (obj is Shoe other)
            {
                if (Id == other.Id && Brand == other.Brand && Name == other.Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
