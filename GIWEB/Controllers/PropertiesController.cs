using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GIWEB.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GIWEB.Models;

namespace GIWEB.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly GIWEBContext _context;

        public PropertiesController(GIWEBContext context)
        {
            _context = context;
        }

        // GET: PropertiesController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Propertie.ToListAsync());
        }

        // GET: PropertiesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PropertiesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropertiesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PropertiesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PropertiesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PropertiesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PropertiesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
