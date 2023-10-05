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
    internal class Sandals : Shoe
    {
        StrapType _strap;
        bool _isOpenToe;
        public override uint Id
        {
            get { return _id; }
            set
            {
                string id = new string("3" + value.ToString());
                _id = uint.Parse(id);
            }
        }
        public StrapType Strap { get { return _strap; } }
        public bool AreOpenToe { get { return _isOpenToe; } }

        public Sandals(uint id, string name, string brand, decimal price, StrapType strap, bool areOpenToe):base(name, brand, price)
        {
            Id = id;
            _strap = strap;
            _isOpenToe = areOpenToe;
        }

        public override void Show()
        {
            Console.WriteLine($"Sandals -\nBrand:{_brand}\nName:{Name}\nOpen Toe:{new string(!_isOpenToe ? "No" : "Yes")}\nStrap Type:{_strap}\nPrice:{Price}");
        }
        public override string ToString()
        {
            return $"Sandals -\nBrand:{_brand}\nName:{Name}\nOpen Toe:{new string(!_isOpenToe ? "No" : "Yes")}\nStrap Type:{_strap}\nPrice:{Price}";
        }
    }
}
