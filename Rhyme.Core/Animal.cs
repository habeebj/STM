using Rhyme.Core.Abstracts;

namespace Rhyme.Core
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; }
        public string Sound { get; }
        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
    }
}