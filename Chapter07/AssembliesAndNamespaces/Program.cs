using System;
using static System.Console;
using System.Xml.Linq;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XDocument();

            // Keyword (better to use keyword over type because you don't need System namespace imported)
            string s1 = "Hello";
            // Type
            String s2 = "World";

            WriteLine($"{s1} {s2}");
        }
    }
}
