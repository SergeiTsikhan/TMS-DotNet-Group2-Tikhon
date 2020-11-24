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
            //var qqq = requestService.GetAwaiter().GetResult();
            Console.ReadKey();
        }
    }
}
