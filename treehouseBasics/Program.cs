using System;
using System.Threading;

namespace treehouseBasics

{
    class Program
    {

        static void Ask(string question) {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            Console.WriteLine(answer);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ask("How many cans are you ordering?");
        }
    }
}
