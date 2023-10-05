using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ShoeShopConsole.Classes.Shoes
{
    enum CushioningLevel
    {
        Low = 1,
        LowPlus,
        Medium,
        MediumPlus,
        High
    };
    internal class SportShoes : IShoe
    {
        uint _id;
        string _name;
        string _brand;
        decimal _price;
        CushioningLevel _cushioning;
        bool _haveArchSupport;
        public uint Id
        {
            get { return _id; }
            set
            {
                string id = new string("1" + value.ToString());
                _id = uint.Parse(id);
            }
        }
        public string Name { get { return _name; } }
        public string Brand { get { return _brand; } }
        public decimal Price { get { return _price; } }
        public CushioningLevel Cushioning { get { return _cushioning; } }
        public bool HaveArchSupport { get { return _haveArchSupport; } }

        public SportShoes(uint id,string name,string brand,decimal price,CushioningLevel cushioning,bool haveArchSupport)
        {
            Id = id;
            _name = name;
            _brand = brand;
            _price = price;
            _cushioning = cushioning;
            _haveArchSupport = haveArchSupport;
        }

        public void Show()
        {
            Console.WriteLine($"Trainers -\nBrand: {_brand}\nName: {Name}\nCushioning: {_cushioning}\nArch Support:{new string(_haveArchSupport ? "Yes" : "No")}\nPrice: {Price}");
        }
        public string ToString()
        {
            return $"Trainers -\nBrand: {_brand}\nName: {Name}\nCushioning: {_cushioning}\nArch Support:{new string(_haveArchSupport ? "Yes" : "No")}\nPrice: {Price}";
        }
        public override bool Equals(object obj)
        {
            if(obj is IShoe other)
            {
                if(Id == other.Id && Brand==other.Brand && Name == other.Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
