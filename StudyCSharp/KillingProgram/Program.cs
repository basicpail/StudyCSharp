using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, };
            int x = 1;
            int y = 0;

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                Console.WriteLine($"{x / y}");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine($"예외가 발생했습니다:{e.Message}");
                Console.WriteLine(e.StackTrace);
                e.HelpLink = "https://docs.microsoft.com/ko-kr/dotnet/api/system.argumentoutofrangeexception?view=netcore-3.1";
                Console.WriteLine($"도움말 링크:{e.HelpLink}");
                    
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine($"다른 예외 발생: {e.Message}");
                Console.WriteLine("0으로 나눌수 없습니다.");
            }

            Console.WriteLine("종료");
        }
    }
}
