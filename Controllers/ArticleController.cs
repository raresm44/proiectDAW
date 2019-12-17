using PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJECT.Controllers
{
    public class ArticleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Article
        public ActionResult Index()
        {
            var articles = from article in db.Articles
                             orderby article.Title
                             select article;
            ViewBag.Articles = articles;
            return View();
        }
        
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Article art)
        {
            try
            {
                db.Articles.Add(art);
                db.SaveChanges();
                TempData["message"] = "Articolul a fost adaugata!";
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}