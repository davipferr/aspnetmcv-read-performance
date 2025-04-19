using System.Collections.Generic;
using QueryPerformance.AppServices.Interfaces;
using QueryPerformance.Helpers;
using QueryPerformance.Models;
using QueryPerformance.Services.Interfaces;

namespace QueryPerformance.AppServices.Implementations
{
    public class RowsAppService : IRowsAppService
    {
        private readonly IRowsService _rowsService;

        public RowsAppService(IRowsService rowsService)
        {
            _rowsService = rowsService;
        }

        public PaginatedList<OneThousandRows> GetPaginatedRows(int page, int recordsPerPage, int groupSize)
        {
            var rows = _rowsService.GetAllRows();

            return PaginatedList<OneThousandRows>.Create(
                rows,
                page,
                recordsPerPage,
                groupSize
            );
        }

        public PaginatedList<OneThousandRows> GetPaginatedRowsFilteredByAge(int minAge, int maxAge, int page, int recordsPerPage, int groupSize)
        {
            var filteredRows = _rowsService.FilterRowsByAge(minAge, maxAge);
            return PaginatedList<OneThousandRows>.Create(filteredRows, page, recordsPerPage, groupSize);
        }
    }
} 