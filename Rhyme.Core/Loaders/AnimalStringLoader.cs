using Rhyme.Core.Abstracts;

namespace Rhyme.Core.Loaders
{
    public class AnimalStringLoader : ILoader<AnimalBase>
    {
        public IEnumerable<AnimalBase> Load(string source)
        {
            // "cow moo, dog gboof"
            var stringArray = source.Split(',').Select(x => x.Trim());
            var animals = stringArray.Select(x =>
            {
                var props = x.Split(' ');
                return new AnimalBase(props[0], props[1]);
            });
            return animals;
        }
    }
}