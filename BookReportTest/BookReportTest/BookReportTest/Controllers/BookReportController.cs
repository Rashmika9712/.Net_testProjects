using BookReportTest.Servicers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace BookReportTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookReportController : ControllerBase
    {
        private readonly IBookReportService _bookReportService;
        public BookReportController(IBookReportService bookReportService)
        {
            _bookReportService = bookReportService;
        }

        [HttpGet]
        [Route("{reportName}/last")]
        public IActionResult GetLast(string reportName)
        {
            var report = _bookReportService.GetLast(reportName);
            if (report == null) 
            {
                return BadRequest();
            }
            //return Json(new { data = "sdf" });
            return Ok(report);
        }

        [HttpPost]
        [Route("{reportName}/{lang}")]
        public ActionResult Create(string lang, string reportName)
        {
            var report = _bookReportService.Create(lang, reportName);
            if (report == null)
            {
                return BadRequest();
            }
            return Ok(report);
        }

        [HttpGet]
        [Route("{reportId}/{pageNumber}/data")]
        public ActionResult GetPage(int reportId, int pageNumber)
        {
            var report = _bookReportService.GetPage(reportId, pageNumber);
            if (report == null)
            {
                return BadRequest();
            }
            return Ok(report);
        }

        [HttpGet]
        [Route("{reportId}")]
        public ActionResult Get(int reportId)
        {
            var report = _bookReportService.GetReport(reportId);
            if (report == null)
            {
                return BadRequest();
            }
            return Ok(report);
        }
    }
}
