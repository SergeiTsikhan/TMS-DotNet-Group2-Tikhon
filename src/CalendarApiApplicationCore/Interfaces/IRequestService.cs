using CalendarApiApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApiApplicationCore.Interfaces
{
    public interface IRequestService
    {
         Task<MainResponse> SeMethod();
        object GetAwaiter();
    }
}
