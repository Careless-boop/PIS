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
    internal class Sneackers : Shoe
    {
        ClosureType _closure;
        HeightType _height;
        public override uint Id
        {
            get { return _id; }
            set
            {
                string id = new string("2" + value.ToString());
                _id = uint.Parse(id);
            }
        }
        public ClosureType Closure { get { return _closure; } }
        public HeightType Height { get { return _height; } }

        public Sneackers(uint id, string name, string brand, decimal price, ClosureType closure, HeightType height):base(name, brand, price)
        {
            Id = id;
            _closure = closure;
            _height = height;
        }

        public override void Show()
        {
            Console.WriteLine($"Sneackers -\nBrand:{_brand}\nName:{Name}\nClosure Type:{_closure}\nHeight:{_height}\nPrice:{Price}");
        }
        public override string ToString()
        {
            return $"Sneackers -\nBrand:{_brand}\nName:{Name}\nClosure Type:{_closure}\nHeight:{_height}\nPrice:{Price}";
        }
    }
}
