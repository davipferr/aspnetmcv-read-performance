using System.Web.Mvc;
using QueryPerformance.AppServices.Interfaces;
using QueryPerformance.Models;

namespace QueryPerformance.Controllers
{
    public class RowsController : Controller
    {
        private readonly IRowsAppService _rowsAppService;

        public RowsController(IRowsAppService rowsAppService)
        {
            _rowsAppService = rowsAppService;
        }

        public ViewResult Thousand(int page = 1, int recordsPerPage = 10, int groupSize = 5)
        {
            var pagedRows = _rowsAppService.GetPaginatedRows(page, recordsPerPage, groupSize);
            return View(pagedRows);
        }

        public ViewResult TenThousand()
        {
            return View();
        }

        public ViewResult HundredThousand()
        {
            return View();
        }

        public ViewResult Million()
        {
            return View();
        }
    }
}
