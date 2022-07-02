// See https://aka.ms/new-console-template for more information

using UserTask;

UserDetails user1 = new UserDetails("Rohan", "K", "Kota", "rohan5@gmail.com", "rohan123");
UserDetails user2 = new UserDetails("Vinod", "Kumar", "Manglore", "vinod@gmail.com", "v@vinod656");
UserDetails user3 = new UserDetails("Jaideep", "P", "Udupi", "jaideep@gmail.com", "vJSis5w");

List<UserDetails> users = new List<UserDetails>();  
users.Add(user1);
users.Add(user2);
users.Add(user3);

foreach(UserDetails user in users)
{ 
    Console.WriteLine(user.FirstName+" Last Login: "+user.dateTime);
}