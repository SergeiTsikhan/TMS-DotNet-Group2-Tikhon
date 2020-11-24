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
            var qqq = requestService.SeMethod("Clark","us").GetAwaiter().GetResult();
            Console.WriteLine(qqq);
            foreach (var item in qqq.results)
            {
                Console.WriteLine(item.month);
                Console.WriteLine(item.day);
                Console.WriteLine(item.name);
            }
            Console.ReadKey();
        }
    }
}
