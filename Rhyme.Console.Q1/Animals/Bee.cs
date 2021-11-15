using Rhyme.Core;

namespace Rhyme.Console.Q1.Animals
{
    public class Bee: Animal
    {
        public Bee(string name = nameof(Bee), string sound = "Buzz") : base(name, sound)
        {
        }
    }
}