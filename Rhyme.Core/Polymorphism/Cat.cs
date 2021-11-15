namespace Rhyme.Core.Polymorphism
{
    public class Cat : Animal
    {
        public Cat(string name = nameof(Cat), string sound = "meow") : base(name, sound)
        {
        }
    }

}