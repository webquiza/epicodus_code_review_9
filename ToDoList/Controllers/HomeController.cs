using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      // after build you can view images here http://localhost:5000/favorite_photos
      
      [Route("/favorite_photos")]
      public ActionResult FavoritePhotos()
      {
        return View();
      }

    }
}