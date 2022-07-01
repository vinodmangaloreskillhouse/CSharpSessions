using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class ShoppingCart
    {
        List<string> Cart = new List<string>();
        public void AddToCart (string item)
        {
            Cart.Add(item);
        }
        public void RemoveFromCart(string item)
        {
            var itemIndex = Cart.IndexOf(item);
            Cart.RemoveAt(itemIndex);

        }
        public void Display()
        {
            foreach (var item in Cart)
            {
                Console.WriteLine(item);
            }
        }


    }
}
