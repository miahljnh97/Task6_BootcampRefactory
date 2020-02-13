using System;
using McMaster.Extensions.CommandLineUtils;
namespace hello_async
{
    [HelpOption("--hlp")]
    [Subcommand(
        typeof(UpperCase),
        typeof(LowerCase)
    )]
    class Program
    {
        public static int Main(string[] args)
        {
            return CommandLineApplication.Execute<Program>(args);
        }
    }
    [Command(Description = "Command to uppercase string", Name = "uppercase")]
    class UpperCase
    {
        [Argument(0)]
        public string text { get; set; }
        public void OnExecute(CommandLineApplication app)
        {
            Console.WriteLine($"{text.ToUpper()}");
        }
    }
    [Command(Description = "Command to lowercase string", Name = "lowercase")]
    class LowerCase
    {
        [Argument(0)]
        public string text { get; set; }
        public void OnExecute(CommandLineApplication app)
        {
            Console.WriteLine($"{text.ToLower()}");
        }
    }
}