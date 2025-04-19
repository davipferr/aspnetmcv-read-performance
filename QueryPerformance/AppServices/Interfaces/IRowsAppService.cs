using System.Collections.Generic;
using QueryPerformance.Helpers;
using QueryPerformance.Models.ViewModels;

namespace QueryPerformance.AppServices.Interfaces
{
    public interface IRowsAppService
    {
        PaginatedList<OneThousandRowsViewModel> GetPaginatedRows(int page, int recordsPerPage, int groupSize);
        PaginatedList<OneThousandRowsViewModel> GetPaginatedRowsFilteredByAge(int minAge, int maxAge, int page, int recordsPerPage, int groupSize);
    }
} 