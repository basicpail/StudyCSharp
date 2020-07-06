using System;
using System.Collections.Generic;
using static System.Console;

namespace LoopStatement
{
    class Program
    {
        static void Main(string[] args)
        {
                List<string> strings = new List<string>();
                strings.Add("Hello");
                strings.Add("Bye");
                strings.Add("Hey!");
                List<string> addstrings = new List<string> { "banana", "strawberry" };
                strings.AddRange(addstrings);

            var i = 0;
            WriteLine(strings);
            WriteLine(strings.GetType());

            foreach (var item in strings)
            {
                WriteLine($"{++i}번째 item:{item}");
            }
        }
    }
}
