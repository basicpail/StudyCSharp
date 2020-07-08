using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            for (int i = 0; i <list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine($"배열크기: {list.Count}");

            Console.Write("추가할 개수 입력: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = list.Count;

            for (int i = list.Count; i < y+x; i++)
            {
                list.Add(i);
                Console.WriteLine($"{i}번째에 데이터 추가완료");
            }
            foreach (object obj in list)
                Console.Write($"{obj} ");

        }
    }
}
