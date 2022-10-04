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
int ageDifference= age- keschasAge;

System.Console.WriteLine($"The difference your and Kescha's age is {ageDifference}");

if(age > keschasAge)
{
    System.Console.WriteLine("You are older!");
}
else if(age == keschasAge)
{
    System.Console.WriteLine("You are equal");
}
else
{
    System.Console.WriteLine("You are younger!");
}

string[] friendsName = new string[3];
friendsName[0] = "Kasse";
friendsName[1] = "Valya";
friendsName[2] = name;
int[] friendsAge = {2,1,age};
for(int i=0; i<friendsName.Length;i++)
{
    System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} years old.");
}