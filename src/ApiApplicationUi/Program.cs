using CalendarApiApplicationCore.Interfaces;
using CalendarApiApplicationCore.Services;
using System;

namespace ApiApplicationUi
{
    class Program
    {
        static void Main(string[] args)
        {
            IRequestService requestService = new RequestService();
            var qqq = requestService.SeMethod("John", "us").GetAwaiter().GetResult();
            foreach (var item in qqq.results)
            {
                Console.WriteLine(item.day);
                Console.WriteLine(item.name);
                Console.WriteLine(item.month);
            }
            Console.ReadKey();
        }
    }
}
