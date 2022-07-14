using Project.NET.CSDL;
using Project.NET.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.NET.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            
            List<ProductModel> products = ProductDao.getAllProduct();
            ViewBag.products = products;
            return View();
        }
    }
}