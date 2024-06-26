﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class ContactSubplaceController : Controller
	{
		ContactManager contactManager = new ContactManager(new EfContactDal());
		[HttpGet]
		public IActionResult Index()
		{
			var values = contactManager.TGetByID(2);
			return View(values);
		}
		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contactManager.TUpdate(contact);
			return RedirectToAction("Index", "Default");
		}
	}
}
