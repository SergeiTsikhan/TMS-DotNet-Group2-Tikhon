using CalendarApiApplicationCore.Constans;
using CalendarApiApplicationCore.Interfaces;
using CalendarApiApplicationCore.Models;
using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApiApplicationCore.Services
{
    public class RequestService : IRequestService
    {
        public async Task<MainResponse> GetdateMeth(string str1,string str2)
        {
            //https://api.abalin.net/getdate?name=John&country=us
            return await Common.Url
                .AppendPathSegments("getdate")
                .SetQueryParams(new
                {
                    name = str1,
                    country = str2,
                })
                .GetJsonAsync<MainResponse>();
        }
        public async Task<MainResponse> TodayMeth(string str1, string str2)
        {
            return await Common.Url
                .AppendPathSegments("today")
                .SetQueryParams(new
                {
                    country = str1,
                    timezone = str2,
                })
                .GetJsonAsync<MainResponse>();
        }
        public async Task<MainResponse> TomorrowMeth(string str1, string str2)
        {
            return await Common.Url
                .AppendPathSegments("tomorrow")
                .SetQueryParams(new
                {
                    country = str1,
                    timezone = str2,
                })
                .GetJsonAsync<MainResponse>();
        }
        public async Task<MainResponse> YesterdayMeth(string str1, string str2)
        {
            return await Common.Url
                .AppendPathSegments("yesterday")
                .SetQueryParams(new
                {
                    country = str1,
                    timezone = str2,
                })
                .GetJsonAsync<MainResponse>();
        }
        public async Task<MainResponse> NamedaysMeth(string str1, int str2, int str3)
        {
            return await Common.Url
                .AppendPathSegments("namedays")
                .SetQueryParams(new
                {
                    country = str1,
                    month = str2,
                    day = str3,
                })
                .GetJsonAsync<MainResponse>();
        }
    }
}
