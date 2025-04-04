using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using DinhLePhat.Context;

namespace DinhLePhat.Controllers
{
    public class ProductController : Controller
    {
        Website_LAEntities objWebsite_LAEntities = new Website_LAEntities();

        // GET: ProductWebsite_LAEntities
        public ActionResult Index()
        {
            var lstProduct = objWebsite_LAEntities.Products.ToList();
            return View(lstProduct);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product objPro)
        {
            objWebsite_LAEntities.Products.Add(objPro);
            objWebsite_LAEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}