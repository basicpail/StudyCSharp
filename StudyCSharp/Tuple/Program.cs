using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1},{a.Item2}");

            var b = (Name: "송상근", Age: 17);
            Console.WriteLine($"{b.Name},{b.Age}");

            var (name, age) = b;
            Console.WriteLine($"{name},{age}");

            b = a;
            Console.WriteLine($"{b.Name},{b.Age}");
        }
    }
}
