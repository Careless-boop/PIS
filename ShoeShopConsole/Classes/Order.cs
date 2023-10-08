using ShoeShopConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShoeShopConsole.Classes
{
    internal class Order : IOrder
    {
        List<IShoe> _orderShoes;
        public List<IShoe> OrderItems { get { return _orderShoes; } }

        public decimal TotalPrice { get { return CalculateTotalPrice(); } }

        public Order(List<IShoe> orderItems)
        {
            _orderShoes = orderItems;
        }
        public void PlaceOrder(IUser user)
        {
            ToFile();
            user.Cart.RemoveAll();
            
        }
        void ToFile()
        {
            StreamWriter sw = new StreamWriter("Order.txt", false, System.Text.Encoding.Default);
            try
            {
                foreach (IShoe shoe in _orderShoes)
                {
                    sw.WriteLine(shoe.ToString());
                    sw.WriteLine("=================================");
                }
                sw.WriteLine($"Total: {TotalPrice}");
                Console.WriteLine("Order file created!");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            { 
                sw.Close();
                Console.Write("Press any button to continue...");
                Console.ReadKey();
            }
        }
        private decimal CalculateTotalPrice()
        {
            // Calculate the total price of all items in the order.
            decimal totalPrice = 0;
            foreach (IShoe shoe in _orderShoes)
            {
                totalPrice += shoe.Price;
            }
            return totalPrice;
        }
    }
}
