namespace Rhyme.Core.Polymorphism
{
    public class Dog : Animal
    {
        public Dog(string name = nameof(Dog), string sound = "Bark") : base(name, sound)
        {
        }
    }

}