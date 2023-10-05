using System;
using System.Collections.Generic;
using System.Text;
using ShoeShopConsole.Classes;

namespace ShoeShopConsole.Interfaces
{
    internal interface IShoe
    {
        uint Id { get; }
        string Name { get; }
        string Brand { get; }
        decimal Price { get; }
        void Show();
        string ToString();
    }
}
