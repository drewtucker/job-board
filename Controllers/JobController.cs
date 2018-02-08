using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/jobs/new")]
        public ActionResult Form()
        {
          return View();
        }


      [HttpPost("/jobs")]
      public ActionResult AddJobPosting()
      {
        Contact newContact = new Contact(Request.Form["contactName"], Request.Form["contactNumber"]);
        Job newJob = new Job(Request.Form["jobTitle"], Request.Form["describe"], newContact);
        newJob.SaveJob();
        return View("JobPostings", Job.AllJobs());
      }
    }
}
