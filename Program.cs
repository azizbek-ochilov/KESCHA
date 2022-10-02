using System;
System.Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
string greeting = $"Hello {name}!";
System.Console.WriteLine(greeting);

System.Console.WriteLine("Enter your age:");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Successfully converted {age}");
int keschasAge = 3;
int ageDifference = age - keschasAge;

System.Console.WriteLine($"The difference your and Kescha's age is {ageDifference}");

System.Console.WriteLine($"You are older than Kescha: {age>keschasAge}");
System.Console.WriteLine($"You are older than or equal to Kescha: {age>=keschasAge}");
System.Console.WriteLine($"You are younger than Kescha: {age<keschasAge}");
System.Console.WriteLine($"You are younger than or equal to Kescha: {age<=keschasAge}");
System.Console.WriteLine($"Your and Kescha's are equal : {age==keschasAge}");
System.Console.WriteLine($"Your and Kescha's are not equal : {age==keschasAge}");

