using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class DashboardController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            ViewBag.v1 = c.Skills.Count();
            ViewBag.v2= c.Messages.Where(x=>x.Status == false).Count();
            ViewBag.v3= c.Messages.Where(x=>x.Status == true).Count();
            ViewBag.v4=c.Experiences.Count();
            return View();
        }
    }
}
