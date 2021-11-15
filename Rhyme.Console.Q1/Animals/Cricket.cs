using Rhyme.Core;

namespace Rhyme.Console.Q1.Animals
{
    public class Cricket : Animal
    {
        public Cricket(string name = nameof(Cricket), string sound = "Chirp") : base(name, sound)
        {
        }
    }
}