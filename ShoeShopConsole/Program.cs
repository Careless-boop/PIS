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
            while (select!=3)
            {
                Console.WriteLine("Select option:\n" +
                                  "0.See available shoes.\n" +
                                  "1.See favorites.\n" +
                                  "2.See cart.\n" +
                                  "3.Exit!");
                if(uint.TryParse(Console.ReadKey(intercept: true).KeyChar.ToString(),out select)&&select<4)
                {
                    switch(select)
                    {
                        case 0:
                            ShoeManager.ShowAvailable(user);
                            break;
                        case 3:
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
