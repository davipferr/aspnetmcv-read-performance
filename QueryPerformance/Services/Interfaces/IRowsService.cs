using System.Collections.Generic;
using QueryPerformance.Models;

namespace QueryPerformance.Services.Interfaces
{
    public interface IRowsService
    {
        IEnumerable<OneThousandRows> GetAllRows();
        IEnumerable<OneThousandRows> FilterRowsByAge(int minAge, int maxAge);
    }
} 