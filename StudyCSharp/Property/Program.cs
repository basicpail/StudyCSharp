using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class BirthdayInfo
    {
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetBirthday(DateTime birth)
        {
            this.Birthday = birth;
        }
        public DateTime GetBirthday()
        {
            return this.Birthday;
        }

        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1993, 09, 01);
        public string PhoneNumber { get; set; } = "010 9341 5993";
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo info = new BirthdayInfo();

            info.Name = "송상근";
            info.Birthday = new DateTime(1993, 09, 01);//값을 변수처럼 대입해줄 수 있음
            Console.WriteLine($"Name:{info.Name}");
            Console.WriteLine($"Birthday : {info.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age:{info.Age}");
            Console.WriteLine($"PhoneNumber:{info.PhoneNumber}");

            Console.WriteLine();

            BirthdayInfo info2 = new BirthdayInfo();
            Console.WriteLine($"Name Default:{info2.Name}");

            //info.SetName("송상근"); //값을 매개변수로 넘겨준다.
            //info.SetBirthday(new DateTime(1993, 09, 01));
            //Console.WriteLine(info.GetName());
            //Console.WriteLine(info.GetBirthday());
            //Console.WriteLine($"{info.GetName()},{info.GetBirthday()}");
        }
    }
}
