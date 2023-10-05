using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Interfaces
{
    internal interface IInventory
    {
        List<IShoe> Shoes { get; }

        void AddShoe(IShoe shoe);
        void RemoveShoe(IShoe shoe);
        void RemoveAll();
        void RemoveAll(IShoe shoe);
    }
}
