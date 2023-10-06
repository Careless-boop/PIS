using ShoeShopConsole.Classes.Shoes;
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
            List<IShoe>[] shoes = ManagePages();
            int select = 1;
            int page = 0;
            while (select!=0)
            {
                int iterator = 1;
                Console.Clear();
                Console.WriteLine("\u001b[2J\u001b[3J");
                if (page == 0 && shoes.Length == 1)
                {
                    Console.WriteLine($"Available shoes:\n0.Return");
                    foreach (IShoe shoe in shoes[page])
                    {
                        Console.Write(iterator + "." + shoes[page].IndexOf(shoe) + ".");
                        shoe.Show();
                        Console.WriteLine("===========================");
                        iterator++;
                    }
                    select = ChooseShown(user, shoes[page]);
                }
                else if(page==0&&shoes.Length > 1)
                {
                    Console.WriteLine($"Available shoes (page:{page}):\n0.Return 5.Next page->");
                    foreach (IShoe shoe in shoes[page])
                    {
                        Console.Write(iterator + "." + shoes[page].IndexOf(shoe) + ".");
                        shoe.Show();
                        Console.WriteLine("===========================");
                        iterator++;
                    }
                    select = ChooseShown(user, shoes[page]);
                    if (select == 5)
                    {
                        page++;
                    }
                }
                else if(page>0&&page+1!=shoes.Length)
                {
                    Console.WriteLine($"Available shoes (page:{page}):\n0.Return 5.Prev page<- 6.Next page->");
                    foreach (IShoe shoe in shoes[page])
                    {
                        Console.Write(iterator + "." + shoes[page].IndexOf(shoe) + ".");
                        shoe.Show();
                        Console.WriteLine("===========================");
                        iterator++;
                    }
                    select = ChooseShown(user, shoes[page]);
                    if(select== 5)
                    {
                        page--;
                    }
                    else if (select == 6)
                    {
                        page++;
                    }
                }
                else if (page > 0 && page+1 == shoes.Length)
                {
                    Console.WriteLine($"Available shoes (page:{page}):\n0.Return 5.Prev page<-");
                    foreach (IShoe shoe in shoes[page])
                    {
                        Console.Write(iterator + "." + shoes[page].IndexOf(shoe) + ".");
                        shoe.Show();
                        Console.WriteLine("===========================");
                        iterator++;
                    }
                    select = ChooseShown(user, shoes[page]);
                    if (select == 5)
                    {
                        page--;
                    }
                }
            }
        }
        static List<IShoe>[] ManagePages()
        {
            DBService dbService = new DBService();
            List<IShoe> temp = dbService.GetShoes();
            int pgcount = (temp.Count / 4) + 1;
            List<IShoe>[] pages = new List<IShoe>[pgcount];
            if (pgcount > 0) pages[0] = new List<IShoe>();
            int i = 0;
            int j = 0;
            foreach (IShoe shoe in temp)
            {
                if (j == 4)
                {
                    i++;
                    pages[i] = new List<IShoe>();
                    j = 0;
                }
                pages[i].Add(shoe);
                j++;
            }
            return pages;
        }
        static int ChooseShown(IUser user,List<IShoe> shoes)
        {
            uint choose;
            while (true)
            {
                if (uint.TryParse(Console.ReadKey(intercept: true).KeyChar.ToString(), out choose) && choose <= shoes.Count)
                {
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
                else if(choose == 5 || choose == 6)
                {
                    return (int)choose;
                }
                Console.Clear();
                Console.WriteLine("\u001b[2J\u001b[3J");
            }
        }
        static void ManageChosen(IUser user,IShoe shoe)
        {
            uint select;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\u001b[2J\u001b[3J");
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
                }
                
            }
        }
    }
}
