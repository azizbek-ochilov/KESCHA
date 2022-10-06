namespace KESCHA.Classes
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeDifference { get; set; }
        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
        }
        
        public Animal(string name, int userAge, int animalAge)
        {
            Name = name;
            Age = animalAge;
            ClaculateAgeDifferenceWithNoReturn(userAge, Age);
        }
        public void PrintAgeDifference()
        {
            Console.WriteLine($"The difference your and {Name} age is {AgeDifference}");
        }
        public void CompareAges(int userAge)
        {
            if(userAge > Age)
            {
                System.Console.WriteLine("You are older!");
            }
            else if(userAge == Age)
            {
                System.Console.WriteLine("You are equal");
            }
            else
            {
                System.Console.WriteLine("You are younger!");
            }
        }
        public void TellAboutFriends(string userName, int userAge)
        {
            string[] friendsName = new string[3];
            friendsName[0] = "Kasse";
            friendsName[1] = "Valya";
            friendsName[2] = userName;
            int[] friendsAge = {2,1,userAge};
            for(int i=0; i<friendsName.Length;i++)
            {
                System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} years old.");
            }
        }
        
        private int ClaculateAgeDifference(int userAge, int Age)
        {
            return userAge - Age;
        }
        
        private void ClaculateAgeDifferenceWithNoReturn(int userAge, int Age)
        {
            AgeDifference = userAge-Age;
        }
    }   
}