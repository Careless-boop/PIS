using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ShoeShopConsole.Classes.Shoes
{
    enum ClosureType
    {
        LaceUp,
        HookAndLoop,
        SlipOn,
        Zip
    }
    enum HeightType
    {
        Low,
        Mid,
        High
    }
    internal class Sneackers : IShoe
    {
        uint _id;
        string _name;
        string _brand;
        decimal _price;
        ClosureType _closure;
        HeightType _height;
        public uint Id
        {
            get { return _id; }
            set
            {
                string id = new string("2" + value.ToString());
                _id = uint.Parse(id);
            }
        }
        public string Name { get { return _name; } }
        public string Brand { get { return _brand; } }
        public decimal Price { get { return _price; } }
        public ClosureType Closure { get { return _closure; } }
        public HeightType Height { get { return _height; } }

        public Sneackers(uint id, string name, string brand, decimal price, ClosureType closure, HeightType height)
        {
            Id = id;
            _name = name;
            _brand = brand;
            _price = price;
            _closure = closure;
            _height = height;
        }

        public void Show()
        {
            Console.WriteLine($"Sneackers -\nBrand:{_brand}\nName:{Name}\nClosure Type:{_closure}\nHeight:{_height}\nPrice:{Price}");
        }
        public string ToString()
        {
            return $"Sneackers -\nBrand:{_brand}\nName:{Name}\nClosure Type:{_closure}\nHeight:{_height}\nPrice:{Price}";
        }
        public override bool Equals(object obj)
        {
            if (obj is IShoe other)
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
