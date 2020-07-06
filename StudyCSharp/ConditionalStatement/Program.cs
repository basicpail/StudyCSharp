using System;
using static System.Console;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            JUMP:
            Write("숫자를 입력하세요: ");
            string input = Console.ReadLine();
            int number;
            if(int.TryParse(input,out number))
            {
                WriteLine("정수형으로 변환성공!");
                if(number > 0)
                {
                    if ((number % 2) == 0)
                        WriteLine($"{number}는 짝수 입니다.");
                    else WriteLine($"{number}는 홀수 입니다.");
                }
            }
            else
            {
                WriteLine("숫자가 아닙니다.");
                goto JUMP;
            }
        }
    }
}
