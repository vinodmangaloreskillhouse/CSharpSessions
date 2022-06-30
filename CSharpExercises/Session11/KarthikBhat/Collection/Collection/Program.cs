// See https://aka.ms/new-console-template for more information

using Collection;

User user1 = new User();
user1.FirstName = "Karthik";
user1.LastName = "Bhat";
user1.Address = "Kundapur";
user1.Email = "bhatkarthik279@gmail.com";
user1.Password = "Karthik125";
user1.LastLoggedIn = new DateTime(2022, 6, 27, 6, 42, 0);

User user2 = new User();
user2.FirstName = "Shashank";
user2.LastName = "bhat";
user2.Address = "banglore";
user2.Email = "bhatiuo@gmail.com";
user2.Password = "3455jkh";
user2.LastLoggedIn = new DateTime(2022, 6, 27, 5, 42, 0);

User user3 = new User();
user3.FirstName = "Ashika";
user3.LastName = " r";
user3.Address = "Manglore";
user3.Email = "ashika@gmail.com";
user3.Password = "8hbewech";
user3.LastLoggedIn = new DateTime(2022, 6, 27, 7, 42, 0);


List<User> list = new List<User>();
list.Add(user1);
list.Add(user2);
list.Add(user3);

Console.WriteLine("First Name of the User are: ");
foreach (User value in list)
{
    value.LastLoggedIn = DateTime.Now;
    Console.WriteLine(value.FirstName);

}