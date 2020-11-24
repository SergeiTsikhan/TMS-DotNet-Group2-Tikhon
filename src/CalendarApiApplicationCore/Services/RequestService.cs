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
        public async Task<MainResponse> SeMethod()
        {
            //https://api.abalin.net/getdate?name=John&country=us
            return await Common.Url
                .AppendPathSegments("tomorrow")
                .GetJsonAsync<MainResponse>();
        }
    }
}
