using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Classes.Shoes
{
    enum StrapType
    {
        FlipFlops,
        Gladiator,
        Slides,
        Strappy
    }
    internal class Sandals : IShoe
    {
        uint _id;
        string _name;
        string _brand;
        decimal _price;
        StrapType _strap;
        bool _isOpenToe;
        public uint Id
        {
            get { return _id; }
            set
            {
                string id = new string("3" + value.ToString());
                _id = uint.Parse(id);
            }
        }
        public string Name { get { return _name; } }
        public string Brand { get { return _brand; } }
        public decimal Price { get { return _price; } }
        public StrapType Strap { get { return _strap; } }
        public bool AreOpenToe { get { return _isOpenToe; } }

        public Sandals(uint id, string name, string brand, decimal price, StrapType strap, bool areOpenToe)
        {
            Id = id;
            _name = name;
            _brand = brand;
            _price = price;
            _strap = strap;
            _isOpenToe = areOpenToe;
        }

        public void Show()
        {
            Console.WriteLine($"Sandals -\nBrand:{_brand}\nName:{Name}\nOpen Toe:{new string(!_isOpenToe ? "No" : "Yes")}\nStrap Type:{_strap}\nPrice:{Price}");
        }
        public string ToString()
        {
            return $"Sandals -\nBrand:{_brand}\nName:{Name}\nOpen Toe:{new string(!_isOpenToe ? "No" : "Yes")}\nStrap Type:{_strap}\nPrice:{Price}";
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
