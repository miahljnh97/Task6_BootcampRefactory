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
    class Program
    {
        static int Main(string[] args)
        {
            return CommandLineApplication.Execute<Program>();
        }

        [Option(Description = "String Transformation")]
        public string Subject { get; set; }


        [Option(ShortName = "n")]
        public int Count { get; }

        private void OnExecute()
        {
            //static void Lowercase()
            //{
            //    Console.WriteLine("Masukkan kalimat yang anda inginkan :");
            //    string args = Console.ReadLine();
            //    string ArgsLow = args.ToLower();
            //    Console.WriteLine($"Lowercaser the sentence : {ArgsLow}");
            //}

            //static void Uppercase()
            //{
            //    Console.WriteLine("Masukkan kalimat yang anda inginkan :");
            //    string args = Console.ReadLine();
            //    string ArgsUp = args.ToUpper();
            //    Console.WriteLine($"Uppercase the sentence : {ArgsUp}");
            //}

            //static void Capitalize()
            //{
            //    Console.WriteLine("Masukkan kalimat yang anda inginkan :");
            //    string args = Console.ReadLine();
            //    char[] ch = ArgsLow.ToCharArray();
            //    if (ch.Length >= 1)
            //    {
            //        if (char.IsLower(ch[0]))
            //        {
            //            ch[0] = char.ToUpper(ch[0]);
            //        }
            //    }
            //    for (int i = 1; i < ch.Length - 1; i++)
            //    {
            //        if (ch[i - 1] == ' ')
            //        {
            //            if (char.IsLower(ch[i]))
            //            {
            //                ch[i] = char.ToUpper(ch[i]);
            //            }
            //        }
            //    }
            //    string rev = new string(ch);
            //    Console.WriteLine($"Capitalize the sentence : {rev}");
            //}

            //static void Sum()
            //{
            //    Console.Write("Masukkan 5 angka yang kamu inginkan satu per satu: ");
            //    int[] data = new int[5];
            //    for (int i = 0; i < data.Length; i++)
            //    {
            //        data[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    int a = data.Sum();
            //    Console.WriteLine($"Sum from data is : {a}");
            //}

            //static void Substract()
            //{
            //    Console.Write("Masukkan 3 angka yang kamu inginkan satu per satu: ");
            //    int[] data = new int[3];
            //    for (int i = 0; i < data.Length; i++)
            //    {
            //        data[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    int b = data[0] - data[1] - data[2];
            //    Console.WriteLine(b);
            //}

            //static void Multiply()
            //{
            //    Console.Write("Masukkan 3 angka yang kamu inginkan satu per satu: ");
            //    int[] data = new int[3];
            //    for (int i = 0; i < data.Length; i++)
            //    {
            //        data[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    int c =data[0] * data[1] * data[2];
            //    Console.WriteLine(c);
            //}

            //static void Divide()
            //{
            //    Console.Write("Masukkan 3 angka yang kamu inginkan satu per satu: ");
            //    int[] data = new int[3];
            //    for (int i = 0; i < data.Length; i++)
            //    {
            //        data[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    int d = (data[0] / data[1]) / data[2];
            //    Console.WriteLine(d);
            //}

            //static void Palindrom()
            //{
            //    Console.WriteLine("Masukkan kata yang anda inginkan;");
            //    string str1 = Console.ReadLine();
            //    string str2 = Regex.Replace(str1, @"[a-zA-Z]+", "");
            //    char[] ch = str2.ToCharArray();
            //    Array.Reverse(ch);
            //    string rev = new string(ch);

            //    Console.WriteLine(str1);
            //    bool y = str2.Equals(rev, StringComparison.OrdinalIgnoreCase);
            //    var yes = y ? "Yes" : "No";
            //    Console.WriteLine($"Is palindrome ? {yes}");
            //}

            //static void Obduscator()
            //{
            //    Console.WriteLine("Masukkan kalimat yang anda inginkan :");
            //    string args = Console.ReadLine();
            //    char[] ch = args.ToCharArray();
            //    List<string> Ob = new List<string>();
            //    foreach (var i in ch)
            //    {
            //        Ob.Add($"&#{Convert.ToString(Convert.ToInt32(i))}");
            //    }
            //    Console.WriteLine(String.Join(';', Ob));
            //}

            //static void Random()
            //{
            //    Random random = new Random();
            //    var all = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            //    var num = "0123456789";
            //    var hur = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            //    Console.WriteLine("Using Number? :");
            //    var Number = Console.ReadLine();
            //    Console.WriteLine("Using letter? :");
            //    var letter = Console.ReadLine();
            //    Console.WriteLine("Uppercase? :");
            //    var upper = Console.ReadLine();


            //    var char10 = new char[10];
            //    var char20 = new char[20];
            //    var char32 = new char[32];
            //    var stringChars = new char[0];

            //    Console.WriteLine("How length? 10, 20, or 32? :");
            //    var len = Convert.ToInt32(Console.ReadLine());
            //    var chars = "";

            //    if (len == 10)
            //    {
            //        stringChars = char10;
            //    }
            //    else if (len == 20)
            //    {
            //        stringChars = char20;
            //    }
            //    else
            //    {
            //        stringChars = char32;
            //    }


            //    if (letter == "false")
            //    {
            //        chars = num;
            //    }
            //    else if (letter == "true" && Number == "false")
            //    {
            //        chars = hur;
            //    }
            //    else
            //    {
            //        chars = all;
            //    }

            //    for (int i = 0; i < stringChars.Length; i++)
            //    {
            //        stringChars[i] = chars[random.Next(chars.Length)];
            //    }

            //    if (upper == "true")
            //    {
            //        var finalStringUp = new String(stringChars).ToUpper();
            //        Console.WriteLine($"Uppercase : {finalStringUp}");
            //    }
            //    else
            //    {
            //        var finalString = new String(stringChars);
            //        Console.WriteLine(finalString);
            //    }
            //}

            //static void Infinite()
            //{
            //    long sum = 0;
            //    string A = "";
            //    while (A != null)
            //    {
            //        Console.Write("Insert Number :");
            //        string B = Console.ReadLine();
            //        if (B == "" || B == " ")
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            long C = Convert.ToInt32(B);
            //            sum += C;
            //        }
            //    }
            //    Console.WriteLine(sum);
            //}

            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            Console.WriteLine(hostName);
            // Get the IP  
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            Console.WriteLine("My IP Address is :" + myIP);
            Console.ReadKey();
        }
    }
}
