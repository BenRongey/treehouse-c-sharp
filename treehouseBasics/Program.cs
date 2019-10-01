using System;
using System.Threading;

namespace treehouseBasics

{
    class Program
    {

        static string Ask(string question) {
            Console.Write(question);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string entry = Ask("How many cans are you ordering?");
            Console.WriteLine(entry);
        }
    }
}
