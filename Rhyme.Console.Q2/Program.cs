using Rhyme.Core;
using Rhyme.Core.Loaders;

// take a copy of the solution and extend to 10 animals

var fileLoader = new AnimalFileLoader();
var data_animals = fileLoader.Load("data.json").ToList();
var ryhmeComposer = new RhymeComposer(data_animals);
var ryhmes = ryhmeComposer.Compose();
Console.WriteLine(ryhmes);