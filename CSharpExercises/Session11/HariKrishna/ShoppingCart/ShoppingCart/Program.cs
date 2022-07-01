// See https://aka.ms/new-console-template for more information

using ShoppingCart;

Shopping shop = new Shopping();
shop.AddtoCart("Sneakers");
shop.AddtoCart("Socks");
shop.AddtoCart("Bags");
shop.AddtoCart("Shirts");
shop.AddtoCart("Pants");
shop.RemoveFromCart("Shirts");
shop.Show();

