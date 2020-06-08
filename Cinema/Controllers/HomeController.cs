using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class HomeController : Controller
    {
        FilmContext db = new FilmContext();

        public ActionResult Index()
        {
            return View(db.Films);
        }
        [HttpPost]
        public ActionResult EditFilm(Film film)
        {
            db.Entry(film).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
            protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        [HttpGet]
        public ActionResult Create()
        {
            SelectList films = new SelectList(db.Films, "Id", "Name");
            ViewBag.Films = films;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Film film)
        {
            db.Films.Add(film);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.FilmId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!Номер Вашей покупки был отправлен на Вашу почту!";
        }
        [HttpGet]
        public ActionResult Login(int? id)
        {
            ViewBag.FilmId = id;
            return View();
        }
        [HttpGet]
        public ActionResult PersonalAccount(int? id)
        {
            ViewBag.FilmId = id;
            return View();
        }

    }
    }
    
    
    
