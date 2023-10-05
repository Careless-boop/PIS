using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Classes
{
    internal class Cart:IInventory
    {
        List<IShoe> _cart;

        public List<IShoe> Shoes { get { return _cart; } }

        public Cart()
        {
            _cart = new List<IShoe>();
        }

        public void AddShoe(IShoe shoe)
        {
            _cart.Add(shoe);
        }
        public void RemoveShoe(IShoe shoe)
        {
            if (_cart.Contains(shoe))
            {
                _cart.Remove(shoe);
            }
            else
            {
                //throw new InvalidOperationException("Are not in your cart!");
                Console.WriteLine("Are not in your cart!");
            }
        }
        public void RemoveAll()
        {
            _cart.Clear();
        }
        public void RemoveAll(IShoe shoe)
        {
            _cart.RemoveAll(t=>t.Id== shoe.Id);
        }
    }
}
