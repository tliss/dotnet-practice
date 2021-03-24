using System;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var taylor = new Person();
            taylor.Name = "Taylor";
            taylor.DateOfBirth = new DateTime(1986, 12, 20);
            taylor.WriteToConsole();
        }
    }
}
