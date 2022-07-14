using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.NET.CSDL;

namespace Project.NET.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.productsTop4 = ProductDao.getAllProducer();
            ViewBag.productsTop = ProductDao.getTopProduct1(4);
            ViewBag.productsProductBS = ProductDao.getTopProductBestSeller(10);
            ViewBag.topProducer = ProductDao.getTopProducer(4);
            return View();
        }
    }
}