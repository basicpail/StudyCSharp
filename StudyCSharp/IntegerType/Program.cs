using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IntegerType
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = sbyte.MinValue;
            sbyte b = sbyte.MaxValue;
            byte d = byte.MaxValue;
            byte c = byte.MinValue;

            uint e = uint.MinValue;
            uint f = uint.MaxValue;

            ulong g = 20_000_000_000_0000_0;

            WriteLine($"{a},{b},{c},{d},{e},{f},{g}");

            byte x = 240;
            WriteLine($"x = {x}");
            byte y = 0b1111_0000;
            WriteLine($"y = {y}");
            byte z = 0xF0;
            WriteLine($"z = {z}");
            byte r = 0xFF;
            WriteLine($"r = {r}");

        }
    }
}
