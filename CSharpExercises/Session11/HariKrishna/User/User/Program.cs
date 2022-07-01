// See https://aka.ms/new-console-template for more informatio

using Collection;

User User1 = new User();
User1.FirstName = "Harikrishna";
User1.LastName = "V";
User1.Email = "srinihari86@gmail.com";
User1.Password = "Krishna69!";
User1.LastLoggedIn = new DateTime(2022, 06, 28, 10, 06, 59);

User User2 = new User();
User2.FirstName = "Pandu";
User2.LastName = "V";
User2.Email = "Xyx6969@gmail.com";
User2.Password = "Pandu6969!";
User2.LastLoggedIn = new DateTime(2022, 06, 29, 12, 19, 21);


List<User> list = new List<User>();
list.Add(User1);
list.Add(User2);

foreach(User item in list)
{
    DateTime LastLoggedIn = DateTime.Now;
}

foreach(User item in list)
{
    Console.WriteLine(item.FirstName);
}
