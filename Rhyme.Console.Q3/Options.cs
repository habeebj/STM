using CommandLine;

namespace Rhyme.Console.Q3
{
    public record Options
    {
        [Option('i', "input", Required = true, HelpText = "Get input in the format [animal] [sound], [animal] [sound] e.g: cow moo, cat meow")]
        public string? Input { get; set; }
    }
}