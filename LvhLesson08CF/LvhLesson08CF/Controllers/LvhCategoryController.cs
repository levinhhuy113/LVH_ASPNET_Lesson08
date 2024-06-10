using LvhLesson08CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LvhLesson08CF.Controllers
{
    
    public class LvhCategoryController : Controller
    {
        private static LvhBookStore _LvhBookStore;
        public LvhCategoryController()
        {
            _LvhBookStore = new LvhBookStore();
        }
        // GET: LvhCategory
        public ActionResult LvhIndex()
        {
            var lvhCategory = _LvhBookStore.LvhCategories.ToList();
            return View(lvhCategory);
        }
        [HttpGet]
        public ActionResult LvhCreate()
        {
            var lvhCategory = new LvhCategory();
            return View(lvhCategory);
        }
        [HttpPost]
        public ActionResult LvhCreate(LvhCategory lvhCategory)
        {
            _LvhBookStore.LvhCategories.Add(lvhCategory);
            _LvhBookStore.SaveChanges();
            return RedirectToAction("LvhIndex");
        }
    }
}