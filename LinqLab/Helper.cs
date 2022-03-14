using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public static class Helper
    {
        public static void Dump(this IEnumerable<Sample> q)
        {
            var index = 0;
            foreach (var item in q)
            {
                Print(item);
                index++;
            }
            ShowMethodName();
            Console.WriteLine("共 " + index + " 筆");

            // Console.ReadKey();
        }

        public static void Dump(this Sample q)
        {
            Print(q);
            ShowMethodName();
        }

        public static void Dump<T>(this IEnumerable<IGrouping<T, Sample>> gq)
        {
            foreach (var item in gq)
            {
                Console.WriteLine($"〈〈〈{item.Key}〉〉〉");
                foreach (var subItem in item)
                {
                    Print(subItem);
                }
            }
        }

        private static void Print(Sample item)
        {
            Console.WriteLine(
           $"Id:{item.Id.ToString("000")} ｜ UserName:{item.UserName} ｜ CreateTime:{item.CreateTime.ToString("yyyy-MM-dd")} ｜ Price:{item.Price} ｜ item:{string.Join(",", item.Item)}");
            Console.WriteLine("——————————————————————————————————————————————————————");
            Console.WriteLine("");
        }

        private static void ShowMethodName()
        {
            var methodName = new StackTrace().GetFrame(2).GetMethod().Name;
            Console.WriteLine($"呼叫方法 {methodName}");
        }
    }
}
