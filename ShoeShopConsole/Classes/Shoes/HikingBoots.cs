using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Classes.Shoes
{
    internal class HikingBoots : Shoe
    {
        float _traction;
        bool _areWaterproof;
        public override uint Id
        {
            get { return _id; }
            set
            {
                string id = new string("4" + value.ToString());
                _id = uint.Parse(id);
            }
        }
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

        public HikingBoots(uint id, string name, string brand, decimal price, float traction, bool areWaterproof):base(name,brand,price)
        {
            Id = id;
            Traction = traction;
            _areWaterproof = areWaterproof;
        }

        public override void Show()
        {
            Console.WriteLine($"Hiking Boots -\nBrand: {_brand}\nName: {Name}\nTraction: {_traction}\nWaterproof:{new string(_areWaterproof ? "Yes" : "No")}\nPrice: {Price}");
        }
        public override string ToString()
        {
            return $"Hiking Boots -\nBrand: {_brand}\nName: {Name}\nTraction: {_traction}\nWaterproof:{new string(_areWaterproof ? "Yes" : "No")}\nPrice: {Price}";
        }
    }
}
