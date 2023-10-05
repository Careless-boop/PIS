using ShoeShopConsole.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Interfaces
{
    internal interface IDataService
    {
        List<IShoe> GetShoes();
    }
}
