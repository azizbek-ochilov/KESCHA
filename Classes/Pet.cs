namespace KESCHA.Classes
{
    public class Pet : Animal
    {
        
        public Pet(string name, int age) : base(name,age)
        {  
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Greeting()
        {
            System.Console.WriteLine($"{AnimalName} says:");
            System.Console.WriteLine($"Meow...");
        }

        public override string ReturnName(string name)
        {
            return UserName;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}