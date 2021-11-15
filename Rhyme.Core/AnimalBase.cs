using Rhyme.Core.Abstracts;

namespace Rhyme.Core
{
    public record AnimalBase(string Name, string Sound) : IAnimal;
}