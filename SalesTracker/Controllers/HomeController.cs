using Microsoft.AspNetCore.Mvc;
using SalesTracker.Models;

namespace SalesTracker.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}