// See https://aka.ms/new-console-template for more information
using EmailApp;

ISendEmail sm = new SendUsingSmtp();
sm.From = "vinod@skill.com";
sm.To = "karthik@gmail.com";
sm.Subject = "New Course";
sm.send();
sm.Delete();

ISendEmail sm2 = new SendUsingSendGrid();
sm.From = "rohan@skill.com";
sm.To = "karthikbhat@gmail.com";
sm.Subject = "Conversation";
sm.send();
sm.Delete();

