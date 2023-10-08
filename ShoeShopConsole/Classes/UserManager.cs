using ShoeShopConsole.Classes.Shoes;
using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Classes
{
    internal class UserManager
    {
        public static void ShowCart(IUser user)
        {
            int select = 1;
            int page = 0;
            while (select != 0)
            {
                List<IShoe>[] cartPages = ShoeManager.ManagePages(user.Cart.Shoes);
                Console.Clear();
                Console.WriteLine("\u001b[2J\u001b[3J");
                Console.Write("Cart");
                select = ShoeManager.ShowPages(user, cartPages, ref page, Cart_ManageChosen);
            }
        }
        public static void ShowFavorites(IUser user)
        {
            int select = 1;
            int page = 0;
            while (select != 0)
            {
                List<IShoe>[] cartPages = ShoeManager.ManagePages(user.Favorites.Shoes);
                Console.Clear();
                Console.WriteLine("\u001b[2J\u001b[3J");
                Console.Write("Favorites");
                select = ShoeManager.ShowPages(user, cartPages, ref page, Favorites_ManageChosen);
            }
        }
        static void Cart_ManageChosen(IUser user, IShoe shoe)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\u001b[2J\u001b[3J");
                shoe.Show();
                Console.WriteLine($"0. Return\n1. Remove from cart\n");
                if (uint.TryParse(Console.ReadKey(intercept: true).KeyChar.ToString(), out uint select) && select < 2)
                {
                    if (select == 0)
                    {
                        return;
                    }
                    else if (select == 1)
                    {
                        user.Cart.RemoveShoe(shoe);
                        return;
                    }
                }

            }
        }
        static void Favorites_ManageChosen(IUser user, IShoe shoe)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\u001b[2J\u001b[3J");
                shoe.Show();
                Console.WriteLine($"0. Return\n1. Remove from favorites\n2. Add to cart");
                if (uint.TryParse(Console.ReadKey(intercept: true).KeyChar.ToString(), out uint select) && select < 3)
                {
                    if (select == 0)
                    {
                        return;
                    }
                    else if (select == 1)
                    {
                        user.Favorites.RemoveShoe(shoe);
                        return;
                    }
                    else
                    {
                        user.Cart.AddShoe(shoe);
                    }
                }

            }
        }
    }
}
