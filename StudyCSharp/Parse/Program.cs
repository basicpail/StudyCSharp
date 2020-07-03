using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            string b = a.ToString();
            Console.WriteLine($"b = {b}");

            float c = 3.141592f;
            string d = c.ToString();
            Console.WriteLine($"d = {d}");

            string e = "123456*";
            int f;
            if (int.TryParse(e, out f))
            {
                Console.WriteLine($"f = {f}");
            }
            else Console.WriteLine("e변환 에러");
            
            string g = "3.141592";
            float h = float.Parse(g);
            if (float.TryParse(g, out h))
            {
                Console.WriteLine($"h = {h}");
            }
            else Console.WriteLine("g변환 에러");
            

        }
    }
}
