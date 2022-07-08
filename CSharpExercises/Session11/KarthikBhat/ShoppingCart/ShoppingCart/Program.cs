// See https://aka.ms/new-console-template for more information
using Shopping;

ShoppingCart cart = new ShoppingCart();
cart.AddToCart("Soap");
cart.AddToCart("Pen");
cart.RemoveFromCart("Soap");
cart.AddToCart("Banana");
cart.AddToCart("Apple");
cart.RemoveFromCart("Banana");
cart.Display();


