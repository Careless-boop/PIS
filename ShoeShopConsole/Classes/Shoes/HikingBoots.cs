using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Classes.Shoes
{
    internal class HikingBoots : IShoe
    {
        uint _id;
        string _name;
        string _brand;
        decimal _price;
        float _traction;
        bool _areWaterproof;
        public uint Id
        {
            get { return _id; }
            set
            {
                string id = new string("4" + value.ToString());
                _id = uint.Parse(id);
            }
        }
        public string Name { get { return _name; } }
        public string Brand { get { return _brand; } }
        public decimal Price { get { return _price; } }
        public float Traction
        {
            get
            {
                return _traction;
            }
            set
            {
                _traction = value > 1 ? 1 : value < 0 ? 0 : value;
            }
        }
        public bool AreWaterproof { get { return _areWaterproof; } }

        public HikingBoots(uint id, string name, string brand, decimal price, float traction, bool areWaterproof)
        {
            Id = id;
            _name = name;
            _brand = brand;
            _price = price;
            Traction = traction;
            _areWaterproof = areWaterproof;
        }

        public void Show()
        {
            Console.WriteLine($"Hiking Boots -\nBrand: {_brand}\nName: {Name}\nTraction: {_traction}\nWaterproof:{new string(_areWaterproof ? "Yes" : "No")}\nPrice: {Price}");
        }
        public string ToString()
        {
            return $"Hiking Boots -\nBrand: {_brand}\nName: {Name}\nTraction: {_traction}\nWaterproof:{new string(_areWaterproof ? "Yes" : "No")}\nPrice: {Price}";
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
