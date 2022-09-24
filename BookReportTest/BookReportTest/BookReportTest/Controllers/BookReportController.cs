using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookReportTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookReportController : ControllerBase
    {
        public BookReportController()
        {
        }

        [HttpGet]
        [Route("{reportName}/last")]
        public ActionResult GetLast()
        {
            return Ok();
        }

        [HttpPost]
        [Route("{reportName}/{lang}")]
        public ActionResult Create()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{reporId}/{pageNumber}/data")]
        public ActionResult GetPage()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{reportId}")]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}
