using System;
using System.Linq;
using McMaster.Extensions.CommandLineUtils;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Net;

namespace CLIChallenge
{
    [HelpOption("--helpp")]
    [Subcommand(
        typeof(Lowercase),
        typeof(Uppercase),
        typeof(Capitalize),
        typeof(Add),
        typeof(Subtract),
        typeof(Multiply),
        typeof(Divide),
        typeof(Palindrome),
        typeof(Obfuscator),
        typeof(Randomize),
        typeof(Infinite),
        typeof(IP),
        typeof(IPEx)
    )]

    class Program
    {
        static int Main(string[] args)
        {
            return CommandLineApplication.Execute<Program>(args);
        }

        [Command(Description = "Command to Lowercase string", Name = "lowercase")]
        class Lowercase
        {
            [Argument(0)]
            public string text { get; set; }
            public void OnExecute(CommandLineApplication app)
            {
                Console.WriteLine($"Lowercase the sentence : {text.ToLower()}");
            }
        }

        [Command(Description = "Command to Uppercase string", Name = "uppercase")]
        class Uppercase
        {
            [Argument(0)]
            public string text { get; set; }
            public void OnExecute(CommandLineApplication app)
            {
                Console.WriteLine($"Uppercase the sentence : {text.ToUpper()}");
            }
        }

        [Command(Description = "Command to Capitalize string", Name = "capitalize")]
        class Capitalize
        {
            [Argument(0)]
            public string text { get; set; }
            public void OnExecute(CommandLineApplication app)
            {
                var textLow = text.ToLower();
                char[] ch = textLow.ToCharArray();
                if (ch.Length >= 1)
                {
                    if (char.IsLower(ch[0]))
                    {
                        ch[0] = char.ToUpper(ch[0]);
                    }
                }
                for (int i = 1; i < ch.Length - 1; i++)
                {
                    if (ch[i - 1] == ' ')
                    {
                        if (char.IsLower(ch[i]))
                        {
                            ch[i] = char.ToUpper(ch[i]);
                        }
                    }
                }
                string rev = new string(ch);
                Console.WriteLine($"Capitalize the sentence : {rev}");
            }
        }

        [Command(Description = "Command to Sum", Name = "add")]
        class Add
        {
            [Argument(0)]
            public int[] num { get; set; }
            public void OnExecute(CommandLineApplication app)
            {
                long sum = 0;
                for(int i = 0; i< num.Length; i++)
                {
                    sum += num[i];
                }
                Console.WriteLine(sum);
            }
        }

        [Command(Description = "Command to Subtract", Name = "subtract")]
        class Subtract
        {
            [Argument(0)]
            public int[] num { get; set; }
            public void OnExecute(CommandLineApplication app)
            {
                long sub = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    sub -= num[i];
                }
                Console.WriteLine(sub);
            }
        }

        [Command(Description = "Command to Multiply", Name = "multiply")]
        class Multiply
        {
            [Argument(0)]
            public int[] num { get; set; }
            public void OnExecute(CommandLineApplication app)
            {
                long mul = num[0];
                for (int i = 1; i < num.Length; i++)
                {
                    mul *= num[i];
                }
                Console.WriteLine(mul);
            }
        }

        [Command(Description = "Command to Divide", Name = "divide")]
        class Divide
        {
            [Argument(0)]
            public int[] num { get; set; }
            public void OnExecute(CommandLineApplication app)
            {
                long div = num[0];
                for (int i = 1; i < num.Length; i++)
                {
                    div /= num[i];
                }
                Console.WriteLine(div);
            }
        }

        [Command(Description = "Command to Palindrome", Name = "palindrome")]
        class Palindrome
        {
            [Argument(0)]
            public string text { get; set; }
            public void OnExecute(CommandLineApplication app)
            {
                string str1 = text.ToLower();
                string str2 = Regex.Replace(str1, @"[a-zA-Z]+", "");
                char[] ch = str2.ToCharArray();
                Array.Reverse(ch);
                string rev = new string(ch);

                Console.WriteLine($"String : { text}");
                bool y = str2.Equals(rev, StringComparison.OrdinalIgnoreCase);
                var yes = y ? "Yes" : "No";
                Console.WriteLine($"Is palindrome ? {yes}");
            }
        }

        [Command(Description = "Command to Obfuscator", Name = "obfuscate")]
        class Obfuscator
        {
            [Argument(0)]
            public string text { get; set; }
            public void OnExecute(CommandLineApplication app)
            {
                char[] ch = text.ToCharArray();
                List<string> Ob = new List<string>();
                foreach (var i in ch)
                {
                    Ob.Add($"&#{Convert.ToString(Convert.ToInt32(i))}");
                }
                Console.WriteLine(String.Join(';', Ob));
            }
        }

        [Command(Description = "Command to Infinity Input", Name = "sum")]
        class Infinite
        {
            public void OnExecute(CommandLineApplication app)
            {
                long sum = 0;
                string A = "";
                while (A != null)
                {
                    Console.Write("Insert Number :");
                    string B = Console.ReadLine();
                    if (B == "" || B == " ")
                    {
                        break;
                    }
                    else
                    {
                        long C = Convert.ToInt32(B);
                        sum += C;
                    }
                }
                Console.WriteLine(sum);
            }
        }

        [Command(Description = "Command to Infinity Input", Name = "random")]
        class Randomize
        {
            [Option("--letters")]
            public string letters { get; set; }
            [Option("--numbers")]
            public string Number { get; set; }
            [Option("--length")]
            public int Length { get; set; }
            [Option("--uppercase")]
            public bool upper { get; set; }
            [Option("--lowercase")]
            public bool lower { get; set; }
            public void OnExecute(CommandLineApplication app)
            {
                Random random = new Random();
                var all = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var num = "0123456789";
                var hur = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                var chars = "";

                var char32 = new char[32];
                var charLen = new char[Length];
                var stringChars = new char[0];

                stringChars = Length == 32 || Length == 0? char32 : charLen;

                if (letters == "false")
                {
                    chars = num;
                }
                else if (letters == "true" && Number == "false")
                {
                    chars = hur;
                }
                else
                {
                    chars = all;
                }

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                if (upper == true)
                {
                    var finalStringUp = new String(stringChars).ToUpper();
                    Console.WriteLine(finalStringUp);
                }
                else if(lower == true)
                {
                    var finalStringLow = new String(stringChars).ToLower();
                    Console.WriteLine(finalStringLow);
                }
                else
                {
                    var finalString = new String(stringChars);
                    Console.WriteLine(finalString);
                }
            }
        }

        [Command(Description = "Command to private IP Address", Name = "ip")]
        class IP
        {
            public void OnExecute(CommandLineApplication app)
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach(var k in host.AddressList)
                {
                    if(k.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        Console.WriteLine($" Your internal IP Address is : {k.ToString()}");
                    }
                }
            }
        }

        [Command(Description = "Command to private IP Address", Name = "ip-external")]
        class IPEx
        {
            public void OnExecute(CommandLineApplication app)
            {
                string k = new WebClient().DownloadString("http://icanhazip.com/");
                Console.WriteLine($" Your external IP Address is : {k}");
            }
        }
    }
}
