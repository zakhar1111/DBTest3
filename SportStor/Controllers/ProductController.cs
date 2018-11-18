using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStor.Models;

namespace SportStor.Controllers
{
    public class ProductController : Controller
    {
        ProductContext db = new ProductContext();
        // GET: Product
        public ActionResult List()
        {
            return View(db.Products.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product pr)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(pr);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(pr);
        }
    }
}