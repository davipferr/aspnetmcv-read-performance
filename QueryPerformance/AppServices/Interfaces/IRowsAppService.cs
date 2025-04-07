using System.Collections.Generic;
using QueryPerformance.Helpers;
using QueryPerformance.Models;

namespace QueryPerformance.AppServices.Interfaces
{
    /// <summary>
    /// Application service interface for rows data presentation
    /// </summary>
    public interface IRowsAppService
    {
        /// <summary>
        /// Gets paginated rows
        /// </summary>
        /// <param name="page">Current page</param>
        /// <param name="recordsPerPage">Records per page</param>
        /// <param name="groupSize">Group size for pagination</param>
        /// <returns>Paginated list of rows</returns>
        PaginatedList<OneThousandRows> GetPaginatedRows(int page, int recordsPerPage, int groupSize);
        
        /// <summary>
        /// Gets paginated rows filtered by age
        /// </summary>
        /// <param name="minAge">Minimum age</param>
        /// <param name="maxAge">Maximum age</param>
        /// <param name="page">Current page</param>
        /// <param name="recordsPerPage">Records per page</param>
        /// <param name="groupSize">Group size for pagination</param>
        /// <returns>Filtered paginated list of rows</returns>
        PaginatedList<OneThousandRows> GetPaginatedRowsFilteredByAge(int minAge, int maxAge, int page, int recordsPerPage, int groupSize);
    }
} 