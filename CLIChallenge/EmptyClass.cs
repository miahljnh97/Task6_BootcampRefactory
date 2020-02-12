using System;
namespace CLIChallenge
{
    public class EmptyClass
    {
        static void Main(string[] args)
        {
            string result = args[1].ToLower();
            Console.WriteLine(String.Join(" ", result));

            //Console.WriteLine("Masukkan kalimat yang anda inginkan :");
            //string args = Console.ReadLine();
            //string ArgsLow = args.ToLower();
            //Console.WriteLine($"Lowercaser the sentence : {ArgsLow}");
        }
    }
}
