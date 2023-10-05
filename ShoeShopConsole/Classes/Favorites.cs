using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml;

namespace ShoeShopConsole.Classes
{
    internal class Favorites:IInventory
    {
        List<IShoe> _favorites;

        public List<IShoe> Shoes {  get { return _favorites; } }

        public Favorites()
        {
            _favorites = new List<IShoe>();
        }

        public void AddShoe(IShoe shoe)
        {
            if (!_favorites.Contains(shoe))
            {
                _favorites.Add(shoe);
            }
            else
            {
                //throw new InvalidOperationException("Already in favorites!");
                Console.WriteLine("Already in favorites!");
            }
        }
        public void RemoveShoe(IShoe shoe)
        {
            if (_favorites.Contains(shoe))
            {
                _favorites.Remove(shoe);
            }
            else
            {
                //throw new InvalidOperationException("Are not in your favorites!");
                Console.WriteLine("Are not in your favorites!");
            }
        }
        public void RemoveAll()
        {
            _favorites.Clear();
        }
        public void RemoveAll(IShoe shoe)
        {
            _favorites.RemoveAll(t=>t.Equals(shoe));
        }
    }
}
