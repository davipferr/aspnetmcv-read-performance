using System.Collections.Generic;
using System.Linq;
using QueryPerformance.AppServices.Interfaces;
using QueryPerformance.Helpers;
using QueryPerformance.Helpers.Mappers;
using QueryPerformance.Models;
using QueryPerformance.Models.ViewModels;
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

        public PaginatedList<OneThousandRowsViewModel> GetPaginatedRows(int page, int recordsPerPage, int groupSize)
        {
            var rows = _rowsService.GetAllRows();
            var viewModels = rows.Select(OneThousandRowsMapper.ToViewModel).ToList();

            return PaginatedList<OneThousandRowsViewModel>.Create(
                viewModels,
                page,
                recordsPerPage,
                groupSize
            );
        }

        public PaginatedList<OneThousandRowsViewModel> GetPaginatedRowsFilteredByAge(int minAge, int maxAge, int page, int recordsPerPage, int groupSize)
        {
            var filteredRows = _rowsService.FilterRowsByAge(minAge, maxAge);
            var viewModels = filteredRows.Select(OneThousandRowsMapper.ToViewModel).ToList();
            
            return PaginatedList<OneThousandRowsViewModel>.Create(
                viewModels,
                page,
                recordsPerPage,
                groupSize
            );
        }
    }
} 