using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShoeShopConsole.Classes
{
    internal class OrderManager
    {
        public static void ShowOrder(IUser user)
        {
            Order order = new Order(user.Cart.Shoes);
            Console.Clear();
            Console.WriteLine("Your order:");
            foreach (IShoe shoe in order.OrderItems)
            {
                Console.WriteLine(shoe.ToString());
                Console.WriteLine("=================================");
            }
            Console.WriteLine($"Total: {order.TotalPrice}");
            bool agree = Agreement();
            if (agree)
            {
                order.PlaceOrder(user);
            }
            else
            {
                return;
            }
        }
        public static bool Agreement()
        {
            Console.WriteLine("Do you agree to purchase?\n0. Yes\n1. No");
            while(true)
            {
                uint select;
                if(uint.TryParse(Console.ReadKey(intercept: true).KeyChar.ToString(), out select)&&select<2)
                {
                    return select==0?true:false;
                }
            }
        }

    }
}
