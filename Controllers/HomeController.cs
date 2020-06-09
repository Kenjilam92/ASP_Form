
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("process")]
        public IActionResult ShowResult(string name, string location, string language, string comment)
        {
            ViewBag.Name=name;
            ViewBag.Location=location;
            ViewBag.language=language;
            ViewBag.Comment=comment;
            return View();
        }
    }
}