using System;
using Chemistry.Core;

namespace Chemistry.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Chemistry World!");
            Element Carbon = new Element("Carbon", "C", 6, 12.0107);
            System.Console.WriteLine($"Number of Neutrons in element {Carbon.ElementName} is {Carbon.Nucleus.NumberOfNeutrons}");
            
        }
    }
}
