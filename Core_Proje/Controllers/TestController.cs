﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
