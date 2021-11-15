using System.Linq;
using Rhyme.Core.Loaders;
using Xunit;

namespace Rhyme.Tests;

public class AnimalLoaderTests
{
    [Theory]
    [InlineData("cat meow", 1)]
    [InlineData("cat meow, cow moo", 2)]
    public void StringLoader_ValidInput_ShouldBeSuccessful(string input, int result)
    {
        var loader = new AnimalStringLoader();
        var animals = loader.Load(input);

        Assert.Equal(result, (int)animals.Count());
    }
}