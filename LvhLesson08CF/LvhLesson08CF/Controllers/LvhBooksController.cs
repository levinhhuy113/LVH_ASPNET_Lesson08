using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LvhLesson08CF.Models;

namespace LvhLesson08CF.Controllers
{
    public class LvhBooksController : Controller
    {
        private LvhBookStore db = new LvhBookStore();

        // GET: LvhBooks
        public ActionResult LvhIndex()
        {
            return View(db.LvhBooks.ToList());
        }

        // GET: LvhBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LvhBook lvhBook = db.LvhBooks.Find(id);
            if (lvhBook == null)
            {
                return HttpNotFound();
            }
            return View(lvhBook);
        }

        // GET: LvhBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LvhBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LvhBookID,LvhTitle,LvhAuthor,LvhYear,LvhPublisher,LvhPicture,LvhCategoryId")] LvhBook lvhBook)
        {
            if (ModelState.IsValid)
            {
                db.LvhBooks.Add(lvhBook);
                db.SaveChanges();
                return RedirectToAction("LvhIndex");
            }

            return View(lvhBook);
        }

        // GET: LvhBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LvhBook lvhBook = db.LvhBooks.Find(id);
            if (lvhBook == null)
            {
                return HttpNotFound();
            }
            return View(lvhBook);
        }

        // POST: LvhBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LvhBookID,LvhTitle,LvhAuthor,LvhYear,LvhPublisher,LvhPicture,LvhCategoryId")] LvhBook lvhBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lvhBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LvhIndex");
            }
            return View(lvhBook);
        }

        // GET: LvhBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LvhBook lvhBook = db.LvhBooks.Find(id);
            if (lvhBook == null)
            {
                return HttpNotFound();
            }
            return View(lvhBook);
        }

        // POST: LvhBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LvhBook lvhBook = db.LvhBooks.Find(id);
            db.LvhBooks.Remove(lvhBook);
            db.SaveChanges();
            return RedirectToAction("LvhIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
