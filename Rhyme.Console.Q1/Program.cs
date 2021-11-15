using Rhyme.Console.Q1.Animals;
using Rhyme.Core;
using Rhyme.Core.Abstracts;
using Rhyme.Core.Loaders;
using Rhyme.Core.Polymorphism;

var dog = new Dog();
var cat = new Cat();
var duck = new Duck();
var bee = new Bee();
var cricket = new Cricket();
var animals = new List<IAnimal> { dog, cat, duck, bee, cricket };

// Polymorphism
System.Console.WriteLine("Polymorphism");
var ryhmeComposer = new RhymeComposer(animals);
var ryhmes = ryhmeComposer.Compose();
Console.WriteLine(ryhmes);

// data-driven
Console.WriteLine("==========================================");
Console.WriteLine("Data Driven");
var fileLoader = new AnimalFileLoader();
var data_animals = fileLoader.Load("data.json").ToList();
ryhmeComposer = new RhymeComposer(data_animals);
ryhmes = ryhmeComposer.Compose();
Console.WriteLine(ryhmes);

// class diagram




// Q4
// I will be opting for the data driven aproach because files can be easily shared accross non-translators in different format like .po or .rexs files
// There available online editors for this files that will make translation easy for non-technical transaltors.