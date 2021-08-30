using OdeToStudy.Data.Models;
using OdeToStudy.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToStudy.Views.Home
{
    public class BooksController : Controller
    {
        private readonly IBooksData db;

        public BooksController(IBooksData db)
        {
            this.db = db;
        }
        // GET: Books
        public ActionResult Index()
        {
            var data = db.GetAll();
            return View(data);
        }
        public ActionResult Details(int id)
        {
            var data = db.Get(id);
            if (data == null)
            {
                return View("NotFound");
            }
            return View(data);
        }
        public ActionResult Create() {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Books MyBooks)
        {
           
            if (ModelState.IsValid)
            {
                db.Add(MyBooks);
                TempData["message"] = "Successfully created a book!";
                return RedirectToAction("Details", new { id = MyBooks.ID});
            }
            return View();
        }
        [HttpPost]
        public ActionResult Edits(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = db.Get(id);
            if( data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Books book)
        {
            if (ModelState.IsValid)
            {
                db.Update(book);
                TempData["message"] = "You have successfully edited the book!";
                return RedirectToAction("Details", new { id = book.ID });
            }
            return View(book);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.Delete(id);
            TempData["message"] = "You have successfully deleted the book!";
            return RedirectToAction("Index");
        }
    }
}