using System;
using System.Linq;

namespace Naming.Task6
{
    public static class Formatter
    {
        private const string Plus = "+";
        private const string Pipe = "|";
        private const string Minus = "-";
        private const string Underscore = " _ ";

        public static void Main(string[] args)
        {
            Console.WriteLine(FormatKeyValue("enable", "true"));
            Console.WriteLine(FormatKeyValue("name", "Bob"));

            Console.Write("Press key...");
            Console.ReadKey();
        }

        private static string FormatKeyValue(string key, string value)
        {
            var content = key + Underscore + value;
            var minuses = Repeat(Minus, content.Length);
            return Plus + minuses + Plus + "\n" +
                   Pipe + content + Pipe + "\n" +
                   Plus + minuses + Plus + "\n";
        }

        private static string Repeat(string symbol, int times)
        {
            return string.Join(string.Empty, Enumerable.Repeat(symbol, times));
        }
    }
}
