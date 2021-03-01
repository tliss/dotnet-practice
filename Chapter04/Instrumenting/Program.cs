using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumentinga
{
    class Program
    {
        static void Main(string[] args)
        {
            // write to a text file in the project folder
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));

            // text writer is buffered, so this option calls Flush() on all listeners
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");
        }
    }
}
