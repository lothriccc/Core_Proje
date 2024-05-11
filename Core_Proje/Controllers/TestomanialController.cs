using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class TestomanialController : Controller
	{
		
		TestomanialManager testomanialManager = new TestomanialManager(new EfTestomanialDal());
		public IActionResult Index()
		{
			var values = testomanialManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddTestomanial()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddTestomanial(Testomanial testomanial)
		{
			testomanialManager.TAdd(testomanial);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteTestomanial(int id)
		{
			var values = testomanialManager.TGetByID(id);
			testomanialManager.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditTestomanial(int id)
		{
			var values = testomanialManager.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditTestomanial(Testomanial testomanial)
		{
			testomanialManager.TUpdate(testomanial);
			return RedirectToAction("Index");
		}
	}
}
