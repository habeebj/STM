namespace Rhyme.Core.Abstracts
{
    public interface ILoader<T>
    {
        IEnumerable<T> Load(string source);
    }


}