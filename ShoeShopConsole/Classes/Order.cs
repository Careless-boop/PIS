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
        public void PlaceOrder()
        {
            OrderManager.ShowOrder(this);
            if (OrderManager.Agreement())
            {

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
