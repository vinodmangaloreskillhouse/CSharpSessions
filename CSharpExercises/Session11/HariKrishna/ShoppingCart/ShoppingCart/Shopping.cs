using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Shopping
    {
        List<string> cart = new List<string>();

        public void AddtoCart(string item)
        {
            cart.Add(item);
        }

        public void RemoveFromCart(string item)
        {
            var itemIndex = cart.IndexOf(item);
            cart.RemoveAt(itemIndex);
        }

        public void Show()
        {
            foreach (var item in cart)
            {
                Console.WriteLine(item);
            }
        }

    }
}
