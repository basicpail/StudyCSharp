using System;
using System.Globalization;
using static System.Console;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hi  Good Morning";

            WriteLine(greeting);
            WriteLine();

            WriteLine($"IndexOf 'Good': {greeting.IndexOf("Good")}");
            WriteLine($"IndexOf 'o' : {greeting.IndexOf('o')}");

            WriteLine($"LastIndexOf 'Good' : {greeting.LastIndexOf("Good")}");
            WriteLine($"LastIndexOf 'o' : {greeting.LastIndexOf("Morning")}");

            WriteLine($"Replaced 'Morning' with 'Evening : { greeting.Replace("Morning", "Evening")}");

            WriteLine();

            string codes = "MSFT,GOOG,AMZN,AAPL,RHT";

            var result = codes.Split(',');
            WriteLine($"result dataType : {result.GetType()}");
            foreach(var item in result)
            {
                WriteLine($"each item '{item.Trim()}'");
            }

            WriteLine();

            DateTime dt = DateTime.Now;
            WriteLine(String.Format("{0:yyyy-MM-dd HH:mm:ss}", dt));
            WriteLine(String.Format($"{dt:yyyy-MM-dd HH:mm:ss}"));
            WriteLine(String.Format("{0:d/M/yyyy HH:mm:ss}", dt));
            WriteLine(String.Format("{0:y yy yyy yyyy}", dt));
            WriteLine(String.Format("{0:M MM MMM MMMM}", dt));
            WriteLine(String.Format("{0:d dd ddd dddd}", dt));

            WriteLine();

            decimal mvalue = 27000000m;
            WriteLine(string.Format($"price {mvalue:C}"));
            WriteLine(mvalue.ToString("C"));
            WriteLine(mvalue.ToString("C", new CultureInfo("en-US")));
            WriteLine(mvalue.ToString("C", new CultureInfo("ja-JP")));



        }
    }
}
