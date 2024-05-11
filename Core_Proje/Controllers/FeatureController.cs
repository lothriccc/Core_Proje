using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Öne Çıkanlar";
            ViewBag.v3 = "Öne Çıkan Sayfası";
            var values = featureManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index","Default");
        }
        //[HttpGet]
        //public IActionResult AddFeature()
        //{
        //    ViewBag.v1 = "Proje Ekleme";
        //    ViewBag.v2 = "Projeler";
        //    ViewBag.v3 = "Proje Ekleme";
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult AddFeature(Feature feature)
        //{
        //    PortfolioValidator validations = new PortfolioValidator();
        //    ValidationResult results = validations.Validate(feature);
        //    if (results.IsValid)
        //    {
        //        featureManager.TAdd(feature);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        foreach (var item in results.Errors)
        //        {
        //            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        //        }
        //    }
        //    return View();
        //}
        //public IActionResult DeleteFeature(int id)
        //{

        //    var values = featureManager.TGetByID(id);
        //    featureManager.TDelete(values);
        //    return RedirectToAction("Index");
        //}
        //[HttpGet]
        //public IActionResult EditFeature(int id)
        //{
        //    ViewBag.v1 = "Proje Güncelleme";
        //    ViewBag.v2 = "Projeler";
        //    ViewBag.v3 = "Proje Güncelleme";
        //    var values = featureManager.TGetByID(id);
        //    return View(values);
        //}
        //[HttpPost]
        //public IActionResult EditFeature(Feature feature)
        //{
        //    PortfolioValidator validations = new PortfolioValidator();
        //    ValidationResult results = validations.Validate(feature);
        //    if (results.IsValid)
        //    {
        //        featureManager.TUpdate(feature);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        foreach (var item in results.Errors)
        //        {
        //            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        //        }
        //    }
        //    return View();
        //}
    }
}
