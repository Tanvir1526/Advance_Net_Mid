using Lab3.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Lab3.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            Entities1 db = new Entities1();
            var data = db.Books.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book b)
        {
           if(ModelState .IsValid)
            {
                Entities1 db = new Entities1();
                db.Books.Add(b);
                db.SaveChanges();
                return RedirectToAction("Index"); 
            }
            return View(b);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Entities1 db = new Entities1();
            var news = (from n in db.Books
                        where n.Id == id select n).FirstOrDefault();
            return View(news);
        }
        [HttpPost]
        public ActionResult Edit(Book sub_b)
        {
            Entities1 db = new Entities1();
            var data = (from s in db.Books
                        where s.Id == sub_b.Id
                        select s).FirstOrDefault();
            db.Entry(data).CurrentValues.SetValues(sub_b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Entities1 db = new Entities1();
            var data = (from s in db.Books
                        where s.Id == id
                        select s).FirstOrDefault();

            return View(data);
        }
        [HttpPost]
        public ActionResult Delete(Book sub_b)
        {
            Entities1 db = new Entities1();
            var data = (from s in db.Books
                        where s.Id == sub_b.Id
                        select s).FirstOrDefault();

            db.Books.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}