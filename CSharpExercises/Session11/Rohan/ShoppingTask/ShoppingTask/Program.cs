// See https://aka.ms/new-console-template for more information

using ShoppingTask;

ShoppingCart itemlist = new ShoppingCart();
itemlist.AddToCart("Mobile");
itemlist.AddToCart("Laptop");
itemlist.AddToCart("Smart Watch");
itemlist.AddToCart("Headphone");
Console.WriteLine("{0} items added to cart: ", itemlist.items.Count);

Console.WriteLine("CART ITEMS");
foreach (var items in itemlist.items)
    Console.WriteLine(items);

itemlist.RemoveFromCart("Mobile");
itemlist.RemoveFromCart("Headphone");
Console.WriteLine("\n{0} items removed from cart: ", itemlist.items.Count);

Console.WriteLine("CART ITEMS");
foreach (var items in itemlist.items)
    Console.WriteLine(items);