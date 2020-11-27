using CalendarApiApplicationCore.Interfaces;
using CalendarApiApplicationCore.Services;
using System;
using System.IO;
using System.Text;

namespace ApiApplicationUi
{
    class Program
    {
        static void Main(string[] args)
        {
            IRequestService requestService = new RequestService();
            var qqq = requestService.SearchDateMethodAsync("Ivan", "us").GetAwaiter().GetResult();

            foreach (var item in qqq.results)
            {
                Console.WriteLine(item.day);
                Console.WriteLine(item.month);
                Console.WriteLine(item.name);
                Console.WriteLine("=======");
            }

            var writePath = $"datesfile_{Guid.NewGuid()}.txt";
            using (StreamWriter sw = new StreamWriter(writePath, false, Encoding.Default))
            {
                foreach (var item in qqq.results)
                {
                    sw.WriteLine(item.day);
                    sw.WriteLine(item.month);
                    sw.WriteLine(item.name);
                    sw.WriteLine("=======");
                }
            }
            Console.ReadKey();
        }
    }
}
