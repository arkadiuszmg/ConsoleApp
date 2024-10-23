using ConsoleApp;
using System.Threading.Tasks.Sources;

User user1 = new User("Antek", "qwerty");
User user2 = new User("Marek", "qwerty");
User user3 = new User("Bartek", "qwerty");
User user4 = new User("Zaneta", "qwerty");

user1.AddScore(5);
user1.AddScore(10);

var result = user1.Result;

Console.WriteLine(result);

