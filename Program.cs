using System;
using KESCHA.Classes;
System.Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
string greeting = $"Hello {name}!";
System.Console.WriteLine(greeting);

System.Console.WriteLine("Enter your age:");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Successfully converted {age}");

Animal kescha = new Animal(name:"Kescha", userAge:age, animalAge:3);
kescha.PrintAgeDifference();
kescha.CompareAges(age);
kescha.TellAboutFriends(userName:name, userAge:age);

