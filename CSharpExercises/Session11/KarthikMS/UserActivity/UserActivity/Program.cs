// See https://aka.ms/new-console-template for more information
using UserActivity;

User user1 = new User()
{
    FirstName = "Keerthan",
    LastName = "MS",
    Address = "Puttur",
    Email = "keerthan@gmail.com",
    Password = "Keerthan#123",
    LastLoggedIn = DateTime.Now
};

User user2 = new User()
{
    FirstName = "Ajith",
    LastName = "K",
    Address = "Mangalore",
    Email = "ajith@gmail.com",
    Password = "Ajith@111",
    LastLoggedIn = DateTime.Now
};

User user3 = new User()
{
    FirstName = "Vivek",
    LastName = "B",
    Address = "Ujire",
    Email = "vivek@gmail.com",
    Password = "Vivek@4545",
    LastLoggedIn = DateTime.Now
};

User user4 = new User()
{
    FirstName = "Manoj",
    LastName = "M",
    Address = "Urva",
    Email = "manoj@gmail.com",
    Password = "ManojABC@999",
    LastLoggedIn = DateTime.Now
};

List<User> Users = new List<User>();

Users.Add(user1);
Users.Add(user2);
Users.Add(user3);
Users.Add(user4);

foreach (User u in Users)
{
    Console.WriteLine("First Name : {0}", u.FirstName);
    Console.WriteLine("Last logged in : {0}", u.LastLoggedIn);
}




