using CalendarApiApplicationCore.Interfaces;
using CalendarApiApplicationCore.Services;
using System;
using System.IO;

namespace ApiApplicationUi
{
    class Program
    {
        static void Main(string[] args)
        {
            IRequestService requestService = new RequestService();
            var qqq = requestService.SeMethod("Clark","us").GetAwaiter().GetResult();
            Console.WriteLine(qqq);
            foreach (var item in qqq.results)
            {
                Console.WriteLine(item.month);
                Console.WriteLine(item.day);
                Console.WriteLine(item.name);
            }
            var writePath = "text.txt";
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                foreach (var item in qqq.results)
                {
                    sw.WriteLine(item.month);
                    sw.WriteLine(item.day);
                    sw.WriteLine(item.name);
                }
            }
            Console.ReadKey();
        }
    }
}
