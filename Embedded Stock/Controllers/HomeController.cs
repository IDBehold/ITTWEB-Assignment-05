using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Embedded_Stock.Models;
using Microsoft.EntityFrameworkCore;

namespace Embedded_Stock.Controllers
{
    public class HomeController : Controller
    {
        private readonly ComponentDbContext _context;

        public HomeController(ComponentDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.ComponentTypes = await _context.ComponentTypes.ToListAsync();
            return View();
        }

        public IActionResult ComponentList([Bind("ComponentTypeId")] int componentTypeId)
        {
            var id = int.Parse(HttpContext.Request.Query["ComponentTypeId"]);
            return View(_context.Components.Where(c => c.ComponentTypeId == id).AsEnumerable());
        }

        public IActionResult ComponentTypesList([Bind("CategoryId")] int categoryId)
        {
            var id = int.Parse(HttpContext.Request.Query["CategoryId"]);
            var relations = _context.CategoryComponentTypes.Where(cct => cct.CategoryId == id);
            var result = new List<ComponentType>();
            foreach (var relation in relations)
            {
                result.AddRange(_context.ComponentTypes.Where(ct => relation.ComponentTypeId == ct.ComponentTypeId));
            }

            return View(result);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
