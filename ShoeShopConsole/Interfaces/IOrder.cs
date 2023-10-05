using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Interfaces
{
    internal interface IOrder
    {
        List<IShoe> OrderItems { get; }
        decimal TotalPrice { get; }

        void PlaceOrder();
    }
}
