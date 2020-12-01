using CalendarApiApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApiApplicationCore.Interfaces
{
    public interface IRequestService
    {
        Task<MainResponse> GetdateMeth(string str1, string str2);
        Task<MainResponse> TodayMeth(string str1, string str2);
        Task<MainResponse> TomorrowMeth(string str1, string str2);
        Task<MainResponse> YesterdayMeth(string str1, string str2);
        Task<MainResponse> NamedaysMeth(string str1, int str2, int str3);
    }
}
