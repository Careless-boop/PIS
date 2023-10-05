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
    internal class HighHeels : Shoe
    {
        HeelsType _heels;
        float _height;
        public override uint Id
        {
            get { return _id; }
            set
            {
                string id = new string("5" + value.ToString());
                _id = uint.Parse(id);
            }
        }
        public HeelsType Heels{ get{ return _heels; } }
        public float HeelsHeight { get { return _height; } }

        public HighHeels(uint id, string name, string brand, decimal price, HeelsType heels, float height):base(name, brand, price)
        {
            Id= id;
            _heels = heels;
            _height = height;
        }

        public override void Show()
        {
            Console.WriteLine($"High Heels -\nBrand: {_brand}\nName: {Name}\nType: {_heels}\nHeels Height: {_height} cm\nPrice: {Price}");
        }
        public override string ToString()
        {
            return $"High Heels -\nBrand: {_brand}\nName: {Name}\nType: {_heels}\nHeels Height: {_height} cm\nPrice: {Price}";
        }
    }
}
