using Microsoft.AspNetCore.Mvc;

namespace CricScoreInfo.Web.Controllers
{
    public class ScorecardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}