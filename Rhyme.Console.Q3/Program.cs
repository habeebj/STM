using CommandLine;
using Rhyme.Console.Q3;
using Rhyme.Core;
using Rhyme.Core.Loaders;

// Extend your program to allow the user to provide their own animals and sounds through the console.

Parser.Default.ParseArguments<Options>(args)
    .WithParsed<Options>(options =>
    {
        // TODO: check with regex
        if (!string.IsNullOrEmpty(options.Input) && options.Input.Contains(' '))
        {
            var stringLoader = new AnimalStringLoader();
            var string_animals = stringLoader.Load(options.Input).ToList();
            var ryhmeComposer = new RhymeComposer(string_animals);
            var ryhmes = ryhmeComposer.Compose();
            Console.WriteLine(ryhmes);
        }
    });

// dotnet run -- -i "cow moo, cat meow"