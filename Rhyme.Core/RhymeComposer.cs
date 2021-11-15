using System.Text;
using Rhyme.Core.Abstracts;

namespace Rhyme.Core
{
    public class RhymeComposer : IComposer
    {
        public IEnumerable<IAnimal> animals;

        public RhymeComposer(IEnumerable<IAnimal> animals) => this.animals = animals;

        public string Compose()
        {
            return string.Join('\n', animals.Select(animal => GetRhyme(animal.Name, animal.Sound)));
        }

        private string GetRhyme(string name, string sound)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Old MacDonald had a farm, E I E I O,");
            sb.AppendLine($"And on his farm he had a {name.ToLower()}, E I E I O.");
            sb.AppendLine($"With a {sound.ToLower()} {sound.ToLower()} here and a {sound.ToLower()} {sound.ToLower()} there,");
            sb.AppendLine($"Here a {sound.ToLower()}, there a  {sound.ToLower()}, everywhere a {sound.ToLower()} {sound.ToLower()}.");
            sb.AppendLine($"Old MacDonald had a farm, E I E I O.");
            return sb.ToString();
        }
    }
}