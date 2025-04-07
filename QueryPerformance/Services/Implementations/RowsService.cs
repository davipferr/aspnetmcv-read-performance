using System.Collections.Generic;
using System.Linq;
using QueryPerformance.Models;
using QueryPerformance.Repositories.Interfaces;
using QueryPerformance.Services.Interfaces;

namespace QueryPerformance.Services.Implementations
{
    public class RowsService : IRowsService
    {
        private readonly IGenericRepository<OneThousandRows> _repository;

        public RowsService(IGenericRepository<OneThousandRows> repository)
        {
            _repository = repository;
        }

        public IEnumerable<OneThousandRows> GetAllRows()
        {
            return _repository.GetAllRows();
        }

        public IEnumerable<OneThousandRows> FilterRowsByAge(int minAge, int maxAge)
        {
            var allRows = _repository.GetAllRows();
            return allRows.Where(row => row.Idade >= minAge && row.Idade <= maxAge);
        }
    }
} 