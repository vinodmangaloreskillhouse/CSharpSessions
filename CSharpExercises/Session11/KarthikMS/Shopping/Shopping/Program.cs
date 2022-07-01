// See https://aka.ms/new-console-template for more information
using Shopping;

ShoppingCart sc=new ShoppingCart();
Console.WriteLine("Before removing the items:");
sc.AddToCart("Book");
sc.AddToCart("Soap");
sc.AddToCart("Bottle");
sc.AddToCart("Shirt");
sc.Display();

sc.RemoveFromCart("Book");
sc.RemoveFromCart("Shirt");
Console.WriteLine("After removing the items:");
sc.Display();

