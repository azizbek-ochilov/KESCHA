namespace KESCHA.Classes
{
    public abstract class Animal
    {
        public int UserAge { get; set; }
        public int AnimalAge { get; set; }
        public string UserName { get; set; }
        public string AnimalName { get; set; }
        public Animal(string name, int age)
        {
            AnimalName = name;
            AnimalAge = age;
        }
        
        public virtual void Greeting()
        {   
            Console.WriteLine("Enter your name:");
            UserName = Console.ReadLine();
            System.Console.WriteLine($"{AnimalName} says:");
            string greeting = $"Hello {UserName}!";
            Console.WriteLine(greeting);
        }
        public abstract string  ReturnName(string UserName);
        
        public void GetInputs()
        {
            Console.WriteLine("Enter your age:");
            UserAge = Convert.ToInt32(Console.ReadLine());
        }
        public int AgeDifference()
        {
            return UserAge-AnimalAge;
        }
        public void CalculateAgeDifference()
        {
            System.Console.WriteLine($"The differnce {AnimalAge} and {UserName}'s is {AgeDifference()} years.");
        }
        public void CompareAges()
        {
            if (UserAge > AnimalAge)
            {
                Console.WriteLine("You are older!");
            }
            else if (UserAge == AnimalAge)
            {
                Console.WriteLine("You are equal");
            }
            else
            {
                Console.WriteLine("You are younger!");
            }
        }
        public void TellAboutFriends()
        {
            string[] friendsName = new string[3];
            friendsName[0] = "Kasse";
            friendsName[1] = "Valya";
            friendsName[2] = UserName;
            int[] friendsAge = { 2, 1, UserAge };
            for (int i = 0; i < friendsName.Length; i++)
            {
                Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} years old.");
            }
        }
    }
}