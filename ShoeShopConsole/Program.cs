using ShoeShopConsole.Classes;
using ShoeShopConsole.Interfaces;
using System;

namespace ShoeShopConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUser user = new User();
            uint select=0;
            while (select!=4)
            {
                Console.WriteLine("Select option:\n" +
                                  "0.See available shoes.\n" +
                                  "1.See favorites.\n" +
                                  "2.See cart.\n" +
                                  (user.Cart.Shoes.Count>0 ?"3.Purchase cart\n" :string.Empty)+
                                  "4.Exit!");
                if(uint.TryParse(Console.ReadKey(intercept: true).KeyChar.ToString(),out select)&&select<5)
                {
                    switch(select)
                    {
                        case 0:
                            ShoeManager.ShowAvailable(user);
                            break;
                        case 1:
                            UserManager.ShowFavorites(user);
                            break;
                        case 2:
                            UserManager.ShowCart(user);
                            break;
                        case 3:
                            if (user.Cart.Shoes.Count > 0)
                                OrderManager.ShowOrder(user);
                            break;
                        case 4:
                            break;
                        default: 
                            break;
                    }
                }
                Console.Clear();
            }
        }
    }
}
