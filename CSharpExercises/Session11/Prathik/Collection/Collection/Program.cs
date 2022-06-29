// See https://aka.ms/new-console-template for more information
using Collection;
User user1 = new User();
user1.FirstName = "Pratik";
user1.LastName = "Naik";
user1.Address = "Murudeshwar";
user1.Email = "pratiknaik08@gmail.com";
user1.Password = "Pratik@123";
user1.LastLoggedIn = new DateTime(2022,06,29,08,27,31);

User user2 = new User();
user2.FirstName = "Vraj";
user2.LastName = "thaker";
user2.Address = "Mumbai";
user2.Email = "vrajthaker10@gmail.com";
user2.Password = "Vraj@123";
user2.LastLoggedIn = new DateTime(2022, 06, 29, 09, 30, 03);

User user3 = new User();
user3.FirstName = "Nikhil";
user3.LastName = "Pawar";
user3.Address = "Karwar";
user3.Email = "nikhilpawar06@gmail.com";
user3.Password = "nikhil@123";
user3.LastLoggedIn = new DateTime(2022, 06, 29, 10, 45, 06);

List<User> users = new List<User>(); ;
users.Add(user1);
users.Add(user2);
users.Add(user3);
foreach (User user in users)
{
    user.LastLoggedIn = DateTime.Now;
}

foreach (User user in users)
{
    Console.WriteLine(user.FirstName);

}