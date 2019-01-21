using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HandsOnEFUsingDBFirst.Models;

namespace HandsOnEFUsingDBFirst.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        [ActionName("GetAll")]
        public ActionResult Index()
        {
            using (BooksDBEntities db = new BooksDBEntities())
            {
                List<Book> list = db.uspGetBooks().ToList();
                return View(list);
            }
                
        }

        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            using (BooksDBEntities db = new BooksDBEntities())
            {
                Book book = db.uspGetBooksById(id).FirstOrDefault();
                return View(book);
            }
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Books/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Books/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
