using System;
using McMaster.Extensions.CommandLineUtils;

namespace CLITraining
{
    [HelpOption("--hlp")]
    class Program
    {
        static int Main(string[] args)
        {
            return CommandLineApplication.Execute<Program>(args);
        }
        [Option(Description = "ikan cupang berwarna biru")]
        public string Subject { get; set; }


        [Option(ShortName ="n")]
        public int Count { get; }


        private void OnExecute()
        {
            var subject = Subject ?? "world";
            for (int i =0; i<Count; i++)
            {
                Console.WriteLine($"Hello {subject}");
            }
        }
    }
}
