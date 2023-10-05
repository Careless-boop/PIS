using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Classes.Shoes
{
    enum HeelsType
    {
        Kitten,
        Block,
        Stiletto,
        Platforms,
        AnkleStrap
    }
    internal class HighHeels : IShoe
    {
        uint _id;
        string _name;
        string _brand;
        decimal _price;
        HeelsType _heels;
        float _height;
        public uint Id
        {
            get { return _id; }
            set
            {
                string id = new string("5" + value.ToString());
                _id = uint.Parse(id);
            }
        }
        public string Name { get { return _name; } }
        public string Brand { get { return _brand; } }
        public decimal Price { get { return _price; } }
        public HeelsType Heels{ get{ return _heels; } }
        public float HeelsHeight { get { return _height; } }

        public HighHeels(uint id, string name, string brand, decimal price, HeelsType heels, float height)
        {
            Id= id;
            _name = name;
            _brand = brand;
            _price = price;
            _heels = heels;
            _height = height;
        }

        public void Show()
        {
            Console.WriteLine($"High Heels -\nBrand: {_brand}\nName: {Name}\nType: {_heels}\nHeels Height: {_height} cm\nPrice: {Price}");
        }
        public string ToString()
        {
            return $"High Heels -\nBrand: {_brand}\nName: {Name}\nType: {_heels}\nHeels Height: {_height} cm\nPrice: {Price}";
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
