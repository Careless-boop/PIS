using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeShopConsole.Classes
{
    internal class ShoeManager
    {
        public static void ShowAvailable(IUser user)
        {
            DBService dBService = new DBService();
            List<IShoe> shoes = dBService.GetShoes();
            int select = 1;
            while (select!=0)
            {
                int iterator = 1;
                Console.Clear();
                Console.WriteLine("Available shoes:\n0.Return");
                foreach (IShoe shoe in shoes)
                {
                    Console.Write(iterator + "." + shoes.IndexOf(shoe) + ".");
                    shoe.Show();
                    Console.WriteLine("===========================");
                    iterator++;
                }
                select = ChooseShown(user);
            }
        }
        static int ChooseShown(IUser user)
        {
            uint choose;
            DBService dBService = new DBService();
            List<IShoe> shoes = dBService.GetShoes();
            while (true)
            {
                if (uint.TryParse(Console.ReadKey(intercept: true).KeyChar.ToString(), out choose) && choose <= shoes.Count)
                {
                    Console.Clear();
                    Console.WriteLine("\u001b[2J\u001b[3J");
                    if (choose == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        ManageChosen(user, shoes.ElementAt((int)choose - 1));
                        return 1;
                    }
                }
                return 0;
            }
        }
        static void ManageChosen(IUser user,IShoe shoe)
        {
            uint select;
            while (true)
            {
                shoe.Show();
                Console.WriteLine($"0. Return\n1. Add to cart\n" +
                              $"{(user.Favorites.Shoes.Contains(shoe) ? "2. Remove from favorites" : "2. Add to favorites")}");
                if (uint.TryParse(Console.ReadKey(intercept: true).KeyChar.ToString(), out select)&&select<3)
                {
                    if(select == 0)
                    {
                    return;
                    }
                    else if(select == 1)
                    {
                        user.Cart.AddShoe(shoe);
                    }
                    else
                    {
                        if (user.Favorites.Shoes.Contains(shoe))
                        {
                            user.Favorites.RemoveShoe(shoe);
                        }
                        else
                        {
                            user.Favorites.AddShoe(shoe);
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("\u001b[2J\u001b[3J");
                }
            }
        }
    }
}
