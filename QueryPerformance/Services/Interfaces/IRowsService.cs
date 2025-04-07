using System.Collections.Generic;
using QueryPerformance.Models;

namespace QueryPerformance.Services.Interfaces
{
    /// <summary>
    /// Domain service interface for rows data processing
    /// </summary>
    public interface IRowsService
    {
        /// <summary>
        /// Gets all rows from the repository
        /// </summary>
        /// <returns>Collection of rows</returns>
        IEnumerable<OneThousandRows> GetAllRows();
        
        /// <summary>
        /// Filters rows by specified criteria
        /// </summary>
        /// <param name="minAge">Minimum age filter</param>
        /// <param name="maxAge">Maximum age filter</param>
        /// <returns>Filtered collection of rows</returns>
        IEnumerable<OneThousandRows> FilterRowsByAge(int minAge, int maxAge);
    }
} 