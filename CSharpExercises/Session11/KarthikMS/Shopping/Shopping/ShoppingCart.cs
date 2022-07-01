using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    internal class ShoppingCart
    {
     
        List<String>Cart=new List<string>();
        public String Items { get; set; }
        public void AddToCart(String Items)
        {
            Cart.Add(Items);
    
        }
        public void RemoveFromCart(String Items)
        {
            var ItemIndex = Cart.IndexOf(Items);
            Cart.RemoveAt(ItemIndex);
        }
        public void Display()
        {
            foreach (var Item in Cart)
            {
                Console.WriteLine(Item);
            }
        } 
    }

}
