using Microsoft.AspNetCore.Mvc;
using SinavApp23MartMvcCore.Models.ORM.Context;
using SinavApp23MartMvcCore.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavApp23MartMvcCore.Controllers
{
    public class DesingController : Controller
    {

        private readonly ProjectContext _db;

        public DesingController(ProjectContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Menus.ToList());
        }

        public IActionResult ContentEkle(int? id)
        {
            var menu = _db.Menus.Find(id);

            return View(menu);
        }
        [HttpPost]
        public IActionResult ContentEkle(Content model)
        {
            if (ModelState.IsValid)
            {
                _db.Contents.Add(model);

                var result = _db.SaveChanges() > 0 ? true : false;

                if (result)
                {
                    return Redirect("/Home/Menu");
                }

            }
            return View();
        }
    }
}
