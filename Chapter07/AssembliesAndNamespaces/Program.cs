using System;
using static System.Console;
using System.Xml.Linq;
using SharedLibrary;

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

            Write("Enter a color value in hex: ");
            string hex = ReadLine();
            WriteLine("Is {0} a valid color value? {1}",
            arg0: hex, arg1: hex.IsValidHex());
            Write("Enter a XML element: ");
            string xmlTag = ReadLine();
            WriteLine("Is {0} a valid XML element? {1}",
            arg0: xmlTag, arg1: xmlTag.IsValidXmlTag());
            Write("Enter a password: ");
            string password = ReadLine();
            WriteLine("Is {0} a valid password? {1}",
            arg0: password, arg1: password.IsValidPassword());
        }
    }
}
