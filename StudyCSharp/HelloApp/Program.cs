using static System.Console; //system이라는 NS안에 Console 클래스를 using하려면 static 필요

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length==0)
            {
                WriteLine("ex: HelloApp.exe<이름>");
                return;
            }
            //Console.WriteLine("Hello, {0}!",args[0]);


            WriteLine($"Hello, {args[0]}!");
        }
    }
}
