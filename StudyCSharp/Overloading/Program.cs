using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Overloading
{
    class Program
    {
        static int plus(int a,int b)
        {
            return a + b;
        }
        static int plus(int a, int b, int c)
        {
            return a + b + c;
        }
        /// <summary>
        /// 덧셈 double형 두 수를 더한다.
        /// </summary>
        /// <param name="a">double a</param>
        /// <param name="b">double b</param>
        /// <returns>double type</returns>
        static double plus(double a, double b)
        {
            return a + b;
        }
        static double plus(double a,double b, double c)
        {
            return a + b+c;
        }
        static void Main(string[] args)
        {
            WriteLine($"{plus(3, 4, 5)},{plus(4.0,5.2)}");
            WriteLine(plus(4.3, 2.41));
        }
    }
}
