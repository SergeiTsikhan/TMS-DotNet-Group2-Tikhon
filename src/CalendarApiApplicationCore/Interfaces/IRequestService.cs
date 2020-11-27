using CalendarApiApplicationCore.Models;
using System.Threading.Tasks;

namespace CalendarApiApplicationCore.Interfaces
{
    public interface IRequestService
    {
        Task<MainResponse> SearchDateMethodAsync(string str1, string str2);
    }
}
