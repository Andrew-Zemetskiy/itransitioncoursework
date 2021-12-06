using CourseResult.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace CourseResult.Controllers
{
	public class HomeController : Controller
	{
		private ApplicationDbContext db;

		public HomeController(ApplicationDbContext context)
		{
			db = context;
		}

		public IActionResult Index()
		{
			//ViewBag.Name = null;
			var overviews = db.Overviews.OrderByDescending(a => a.Grade);
			return View(overviews.ToList());
		}
		[HttpGet]
		public IActionResult Edit(int? id)
		{
			if (id == null)
			{
				return Error();
			}
			Overview overview = db.Overviews.Find(id);
			if (overview == null)
			{
				return Error();
			}

			return View(overview);
		}

		[HttpPost]
		public IActionResult Edit(Overview overview)
		{
			db.Entry(overview).State = EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Overview overview)
		{
			db.Overviews.Add(overview);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Viewing(int? id)
		{
			if (id == null)
			{
				return Content("Указанная страница не найдена!");
			}
			Overview overview = db.Overviews.Find(id);
			if (overview == null)
			{
				return Content("Указанный обзор не был найден!");
			}
			return View(overview);
		}

		[HttpGet]
		public IActionResult Delete(int? id)
		{
			if (id == null)
			{
				return Error();
			}
			Overview overview = db.Overviews.Find(id);
			if (overview == null)
			{
				return Error();
			}
			return View(overview);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult DeleteConfirmed(int? id)
		{
			if (id == null)
			{
				return Error();
			}
			Overview player = db.Overviews.Find(id);
			if (player == null)
			{
				return Error();
			}
			db.Overviews.Remove(player);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult Cinema()
		{
			var overviews = db.Overviews.Where(a => a.Category == "Cinema").OrderByDescending(c => c.Grade);
			return View(overviews.ToList());
		}

		public IActionResult Books()
		{
			var overviews = db.Overviews.Where(a => a.Category == "Books").OrderByDescending(c => c.Grade);
			return View(overviews.ToList());
		}

		public IActionResult Games()
		{
			var overviews = db.Overviews.Where(a => a.Category == "Games").OrderByDescending(c => c.Grade);
			return View(overviews.ToList());
		}

		public IActionResult Music()
		{
			var overviews = db.Overviews.Where(a => a.Category == "Music").OrderByDescending(c => c.Grade);
			return View(overviews.ToList());
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
