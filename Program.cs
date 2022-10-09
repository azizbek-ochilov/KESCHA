using System;
using KESCHA.Classes;
internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Animal kescha = new Bird("Birdy", 5);
            Animal maysa = new Pet("Maysa", 6);
            kescha.Greeting();
            maysa.Greeting();
            kescha.GetInputs();
            kescha.CalculateAgeDifference();
            kescha.CompareAges();
            kescha.TellAboutFriends();   
        }
        catch(FormatException formatException)
        {
            System.Console.WriteLine($" Error detected: {formatException.Message}");
        }
        catch (Exception exception)
        {
            System.Console.WriteLine("Error was detected but type is unknown!");
        }
        System.Console.WriteLine("Program ended...");

    }
}