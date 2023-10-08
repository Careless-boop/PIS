using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Classes
{
    internal class User : IUser
    {
        Cart _cart;
        Favorites _favorites;

        public IInventory Cart
        {
            get { return _cart; }
        }

        public IInventory Favorites
        {
            get { return _favorites; }
        }

        public User()
        {
            _cart = new Cart();
            _favorites = new Favorites();
        }
    }
}
