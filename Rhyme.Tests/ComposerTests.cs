using System.Collections.Generic;
using Rhyme.Core;
using Rhyme.Core.Polymorphism;
using Xunit;

namespace Rhyme.Tests
{
    public class ComposerTests
    {
        [Fact]
        public void Composer_ValidInput_ShouldBeSuccessful()
        {
            var cat = new Cat();
            var animals = new List<Animal> { cat };
            var composer = new RhymeComposer(animals);
            var rhyme = composer.Compose();
            
            Assert.Contains(nameof(cat), rhyme);
            Assert.Contains(cat.Sound, rhyme);
        }
    }
}