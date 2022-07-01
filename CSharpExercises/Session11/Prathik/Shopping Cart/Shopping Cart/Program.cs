// See https://aka.ms/new-console-template for more information
using Shopping;
ShoppingCart cart = new ShoppingCart();
cart.AddToCart("Book");
cart.AddToCart("Pencil");
cart.RemoveFromCart("Book");
cart.AddToCart("Toys");
cart.AddToCart("Bread");
cart.RemoveFromCart("Toys");
cart.Display();
