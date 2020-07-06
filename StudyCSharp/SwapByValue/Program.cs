using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace SwapByValue
{
    class Program
    {
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            WriteLine($"x:{x}, y:{y}");

            Swap(x,y);

            WriteLine($"x:{x}, y:{y}");
            //함수를 호출해도 값이 Swap되지않는다.
        }
    }
}
