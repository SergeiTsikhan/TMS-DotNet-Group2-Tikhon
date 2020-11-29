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
            var qqq = requestService.SeMethod("Barack","us").GetAwaiter().GetResult();
            Console.WriteLine(qqq);
            foreach (var item in qqq.results)
            {
                Console.WriteLine($"Number of month: {item.month}") ;
                Console.WriteLine($"Number of day: {item.day}");
                Console.WriteLine($"Who has namedays in this day: {item.name}");
            }
            var writePath = "text.txt";
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                foreach (var item in qqq.results)
                {
                    sw.WriteLine($"Number of month: {item.month}");
                    sw.WriteLine($"Number of day: {item.day}");
                    sw.WriteLine($"Who has namedays in this day: {item.name});
                }
            }
            Console.ReadKey();
        }
    }
}
