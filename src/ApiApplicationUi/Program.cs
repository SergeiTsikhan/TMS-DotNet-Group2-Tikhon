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
            bool check = true;
            IRequestService requestService = new RequestService();
            var writePath = "text.txt";

            while (check == true)
            {
                ConsoleText3();
                var userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        GetdateReq(requestService, writePath);
                        check = CheckInputInGeneral();
                        break;
                    case 2:
                        TodayReq(requestService, writePath);
                        check = CheckInputInGeneral();
                        break;
                    case 3:
                        NamedaysReq(requestService, writePath);
                        check = CheckInputInGeneral();
                        break;
                    case 4:
                        TomorrowReq(requestService, writePath);
                        check = CheckInputInGeneral();
                        break;
                    case 5:
                        YesterdayReq(requestService, writePath);
                        check = CheckInputInGeneral();
                        break;
                    case 0:
                        check = false;
                        break;
                }
            }

            Console.ReadKey();
        }

        static void GetdateReq(IRequestService requestService, string writePath)
        {
            bool Check = true;
            while (Check == true)
            {
                Console.Write("Write a name: ");
                var str1 = Console.ReadLine();
                Console.Write("Write a region: ");
                var str2 = Console.ReadLine();
                var result = requestService.GetdateMeth(str1, str2).GetAwaiter().GetResult();
                ConsoleText1();
                var str3 = Console.ReadLine();
                switch (str3)
                {
                    case "1":
                        foreach (var item in result.results)
                        {
                            Console.WriteLine($"Number of month: {item.month}");
                            Console.WriteLine($"Number of day: {item.day}");
                            Console.WriteLine($"Who has namedays in this day: {item.name}");
                        }
                        break;
                    case "2":
                        using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                            foreach (var item in result.results)
                            {
                                sw.WriteLine($"Number of month: {item.month}");
                                sw.WriteLine($"Number of day: {item.day}");
                                sw.WriteLine($"Who has namedays in this day: {item.name}");
                            }
                        break;
                    default:
                        break;
                }
                Check = CheckInput();
            }
        }

        static void TodayReq(IRequestService requestService, string writePath)
        {
            bool Check = true;
            while (Check == true)
            {
                Console.WriteLine("Write a region: ");
                var str1 = Console.ReadLine();
                Console.WriteLine("Write timezone: ");
                var str2 = Console.ReadLine();
                var result = requestService.TodayMeth(str1, str2).GetAwaiter().GetResult();
                ConsoleText1();
                var str3 = Console.ReadLine();
                switch (str3)
                {
                    case "1":
                        if (str1 == "pl")
                        {
                            Console.WriteLine($"Number of month: {result.data.dates.month}");
                            Console.WriteLine($"Number of day: {result.data.dates.day}");
                            Console.WriteLine($"Who has namedays in this day: {result.data.namedays.pl}");
                        }
                        else if (str1 == "us")
                        {
                            Console.WriteLine($"Number of month: {result.data.dates.month}");
                            Console.WriteLine($"Number of day: {result.data.dates.day}");
                            Console.WriteLine($"Who has namedays in this day: {result.data.namedays.us}");
                        }
                        break;
                    case "2":
                        if (str1 == "pl")
                        {
                            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine($"Number of month: {result.data.dates.month}");
                                sw.WriteLine($"Number of day: {result.data.dates.day}");
                                sw.WriteLine($"Who has namedays in this day: {result.data.namedays.pl}");
                            }
                        }
                        else if (str1 == "us")
                        {
                            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine($"Number of month: {result.data.dates.month}");
                                sw.WriteLine($"Number of day: {result.data.dates.day}");
                                sw.WriteLine($"Who has namedays in this day: {result.data.namedays.us}");
                            }
                        }
                        break;
                    default:
                        break;
                }
                Check = CheckInput();
            }
        }

        static void NamedaysReq(IRequestService requestService, string writePath)
        {
            bool Check = true;
            while (Check == true)
            {
                Console.WriteLine("Write a region: ");
                var str1 = Console.ReadLine();
                Console.WriteLine("Write number of month: ");
                var str2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write number of day: ");
                var str3 = Convert.ToInt32(Console.ReadLine());
                var result = requestService.NamedaysMeth(str1, str2, str3).GetAwaiter().GetResult();
                ConsoleText1();
                var str4 = Console.ReadLine();
                switch (str4)
                {
                    case "1":
                        if (str1 == "pl")
                        {
                            Console.WriteLine($"Number of month: {result.data.dates.month}");
                            Console.WriteLine($"Number of day: {result.data.dates.day}");
                            Console.WriteLine($"Who has namedays in this day: {result.data.namedays.pl}");
                        }
                        else if (str1 == "us")
                        {
                            Console.WriteLine($"Number of month: {result.data.dates.month}");
                            Console.WriteLine($"Number of day: {result.data.dates.day}");
                            Console.WriteLine($"Who has namedays in this day: {result.data.namedays.us}");
                        }
                        break;
                    case "2":
                        if (str1 == "pl")
                        {
                            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine($"Number of month: {result.data.dates.month}");
                                sw.WriteLine($"Number of day: {result.data.dates.day}");
                                sw.WriteLine($"Who has namedays in this day: {result.data.namedays.pl}");
                            }
                        }
                        else if (str1 == "us")
                        {
                            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine($"Number of month: {result.data.dates.month}");
                                sw.WriteLine($"Number of day: {result.data.dates.day}");
                                sw.WriteLine($"Who has namedays in this day: {result.data.namedays.us}");
                            }
                        }
                        break;
                }
                Check = CheckInput();
            }
        }

        static void TomorrowReq(IRequestService requestService, string writePath)
        {
            bool Check = true;
            while(Check == true)
            {
                Console.WriteLine("Write a region: ");
                var str1 = Console.ReadLine();
                Console.WriteLine("Write a timezone: ");
                var str2 = Console.ReadLine();
                var result = requestService.TomorrowMeth(str1, str2).GetAwaiter().GetResult();
                ConsoleText1();
                var str3 = Console.ReadLine();
                switch (str3)
                {
                    case "1":
                        if (str1 == "pl")
                        {
                            Console.WriteLine($"Number of month: {result.data.dates.month}");
                            Console.WriteLine($"Number of day: {result.data.dates.day}");
                            Console.WriteLine($"Who has namedays in this day: {result.data.namedays.pl}");
                        }
                        else if (str1 == "us")
                        {
                            Console.WriteLine($"Number of month: {result.data.dates.month}");
                            Console.WriteLine($"Number of day: {result.data.dates.day}");
                            Console.WriteLine($"Who has namedays in this day: {result.data.namedays.us}");
                        }
                        break;
                    case "2":
                        if (str1 == "pl")
                        {
                            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine($"Number of month: {result.data.dates.month}");
                                sw.WriteLine($"Number of day: {result.data.dates.day}");
                                sw.WriteLine($"Who has namedays in this day: {result.data.namedays.pl}");
                            }
                        }
                        else if (str1 == "us")
                        {
                            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine($"Number of month: {result.data.dates.month}");
                                sw.WriteLine($"Number of day: {result.data.dates.day}");
                                sw.WriteLine($"Who has namedays in this day: {result.data.namedays.us}");
                            }
                        }
                        break;
                }
                Check = CheckInput();
            }
        }

        static void YesterdayReq(IRequestService requestService, string writePath)
        {
            bool Check = true;
            while (Check == true)
            {
                Console.WriteLine("Write a region: ");
                var str1 = Console.ReadLine();
                Console.WriteLine("Write a timezone: ");
                var str2 = Console.ReadLine();
                var result = requestService.YesterdayMeth(str1, str2).GetAwaiter().GetResult();
                ConsoleText1();
                var str3 = Console.ReadLine();
                switch (str3)
                {
                    case "1":
                        if (str1 == "pl")
                        {
                            Console.WriteLine($"Number of month: {result.data.dates.month}");
                            Console.WriteLine($"Number of day: {result.data.dates.day}");
                            Console.WriteLine($"Who has namedays in this day: {result.data.namedays.pl}");
                        }
                        else if (str1 == "us")
                        {
                            Console.WriteLine($"Number of month: {result.data.dates.month}");
                            Console.WriteLine($"Number of day: {result.data.dates.day}");
                            Console.WriteLine($"Who has namedays in this day: {result.data.namedays.us}");
                        }
                        break;
                    case "2":
                        if (str1 == "pl")
                        {
                            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine($"Number of month: {result.data.dates.month}");
                                sw.WriteLine($"Number of day: {result.data.dates.day}");
                                sw.WriteLine($"Who has namedays in this day: {result.data.namedays.pl}");
                            }
                        }
                        else if (str1 == "us")
                        {
                            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine($"Number of month: {result.data.dates.month}");
                                sw.WriteLine($"Number of day: {result.data.dates.day}");
                                sw.WriteLine($"Who has namedays in this day: {result.data.namedays.us}");
                            }
                        }
                        break;
                }
                Check = CheckInput();
            }
        }

        static void ConsoleText1()
        {
            Console.WriteLine("How would you like to receive the request: ");
            Console.WriteLine("1. In console.");
            Console.WriteLine("2. In file.");
        }
        static void ConsoleText3()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What request would you like to make?");
            Console.WriteLine("1. Get namedays by Date.");
            Console.WriteLine("2. Get info who has namedays today.");
            Console.WriteLine("3. Get namedays by Name.");
            Console.WriteLine("4. Get info who has namedays tomorrow.");
            Console.WriteLine("5. Get info who has namedays yersteday.");
            Console.WriteLine("0. Exit from the program.");
        }
        static bool CheckInput()
        {
            Console.WriteLine("Wanna make on more request? ");
            Console.WriteLine("1. Yes.");
            Console.WriteLine("2. No.");
            var str4 = Console.ReadLine();
            if (str4 == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool CheckInputInGeneral()
        {
            Console.WriteLine("Wanna make on more request in general? ");
            Console.WriteLine("1. Yes.");
            Console.WriteLine("2. No.");
            var str4 = Console.ReadLine();
            if (str4 == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
