using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingTask
{
    internal class ShoppingCart
    {
        public List<string> items = new List<string>();

        public void AddToCart(string item)
        {
            items.Add(item);
        }

        public void RemoveFromCart(string item)
        {
            var itemIndex = items.IndexOf(item);
            items.RemoveAt(itemIndex);
        }

    }
}
