using System.Text.Json;
using Rhyme.Core.Abstracts;

namespace Rhyme.Core.Loaders
{
    public class AnimalFileLoader : ILoader<AnimalBase>
    {
        public IEnumerable<AnimalBase> Load(string source)
        {
            var jsonContent = File.ReadAllText(source);
            var obj = JsonSerializer.Deserialize<IEnumerable<AnimalBase>>(jsonContent);
            if (obj is null)
                throw new ArgumentNullException(nameof(AnimalBase));
            
            return obj;
        }
    }
}