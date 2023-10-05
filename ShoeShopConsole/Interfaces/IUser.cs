using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Interfaces
{
    internal interface IUser
    {
        IInventory Cart { get; }
        IInventory Favorites { get; }

        void PurchaseCart();
    }
}
