using KESCHA.Classes;
namespace KESCHA.Classes
{
    public class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public override string ReturnName(string UserName)
        {
            throw new NotImplementedException();
        }
    }
}   