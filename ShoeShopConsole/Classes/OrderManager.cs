using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShoeShopConsole.Classes
{
    internal class OrderManager
    {
        public static void ShowOrder(Order order)
        {
            Console.WriteLine("Your order:");
            foreach (IShoe shoe in order.OrderItems)
            {
                Console.WriteLine(shoe.ToString());
                Console.WriteLine("=================================");
            }
            Console.WriteLine($"Total: {order.TotalPrice}");
        }
        public static void ToFile(Order order)
        {
            StreamWriter sw = new StreamWriter("Order.txt", false, System.Text.Encoding.Default);
            try
            {
                foreach (IShoe shoe in order.OrderItems)
                {
                    sw.WriteLine(shoe.ToString());
                    sw.WriteLine("=================================");
                }
                sw.WriteLine($"Total: {order.TotalPrice}");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { sw.Close(); }
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
                Console.Write("Invalid input.Try again!\n0. Yes\n1. No");
            }
        }

    }
}
