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
    internal class SportShoes : Shoe
    {
        CushioningLevel _cushioning;
        bool _haveArchSupport;
        public override uint Id
        {
            get { return _id; }
            set
            {
                string id = new string("1" + value.ToString());
                _id = uint.Parse(id);
            }
        }
        public CushioningLevel Cushioning { get { return _cushioning; } }
        public bool HaveArchSupport { get { return _haveArchSupport; } }

        public SportShoes(uint id,string name,string brand,decimal price,CushioningLevel cushioning,bool haveArchSupport):base(name,brand,price)
        {
            Id = id;
            _cushioning = cushioning;
            _haveArchSupport = haveArchSupport;
        }

        public override void Show()
        {
            Console.WriteLine($"Trainers -\nBrand: {_brand}\nName: {Name}\nCushioning: {_cushioning}\nArch Support:{new string(_haveArchSupport ? "Yes" : "No")}\nPrice: {Price}");
        }
        public override string ToString()
        {
            return $"Trainers -\nBrand: {_brand}\nName: {Name}\nCushioning: {_cushioning}\nArch Support:{new string(_haveArchSupport ? "Yes" : "No")}\nPrice: {Price}";
        }
    }
}
