using CricScoreInfo.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CricScoreInfo.Web.Controllers
{
  public class AuthenticateController : Controller
  {
    public ViewResult Index(AuthenticateViewModel model)
    {
      return View(model);
    }
  }
}