using NguyenDaoDuyTan_1811063479_Lab03.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenDaoDuyTan_1811063479_Lab03.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ListBook()
        {
            BookManagerContext context = new BookManagerContext();
            var listBook = context.Books.ToList();
            return View(listBook);
        }

        [Authorize]
        public ActionResult Buy(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book book = context.Books.SingleOrDefault(p => p.ID == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            BookManagerContext context = new BookManagerContext();
            var search = context.Books.SingleOrDefault(p => p.ID == book.ID);
            if (search != null)
            {
                return HttpNotFound();
            }
            else
            {
                context.Books.AddOrUpdate(book);
                context.SaveChanges();
                return RedirectToAction("ListBook");
            }
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book search = context.Books.SingleOrDefault(p => p.ID == id);
            if (search == null)
            {
                return HttpNotFound();
            }
            return View(search);
        }
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            BookManagerContext context = new BookManagerContext();
            Book search = context.Books.FirstOrDefault(p => p.ID == book.ID);
            if (search == null)
            {
                return HttpNotFound();
            }
            else
            {
                UpdateModel(search);
                context.SaveChanges();
                return RedirectToAction("ListBook");
            }
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book search = context.Books.FirstOrDefault(p => p.ID == id);
            if (search == null)
            {

                return HttpNotFound();
            }

            return View(search);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Book book)
        {
            BookManagerContext context = new BookManagerContext();
            Book search = context.Books.FirstOrDefault(p => p.ID == book.ID);
            if (search == null)
            {

                return HttpNotFound();
            }
            else
            {

                context.Books.Remove(search);
                context.SaveChanges();
                return RedirectToAction("ListBook");
            }
        }

        public ActionResult Details(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book search = context.Books.FirstOrDefault(p => p.ID == id);
            if (search == null)
            {
                return HttpNotFound();
            }
            return View(search);
        }
    }
}