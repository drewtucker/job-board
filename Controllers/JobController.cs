using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
        public ActionResult Form()
        {
          return View();
        }

      [HttpGet("/Jobs")]
      public ActionResult JobPostings()
      {
        return View();
      }
    }
}
