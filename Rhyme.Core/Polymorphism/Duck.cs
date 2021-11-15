namespace Rhyme.Core.Polymorphism
{
    public class Duck : Animal
    {
        public Duck(string name = nameof(Duck), string sound = "quack") : base(name, sound)
        {
        }
    }
}