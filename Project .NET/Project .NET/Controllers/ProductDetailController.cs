using Project.NET.CSDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.NET.Models;

namespace Project.NET.Controllers
{
    public class ProductDetailController : Controller
    {
        // GET: ProductDetail
        public ActionResult Index(String id)
        {
           ProductDao productDao = new ProductDao();
           ProductModel productModel = productDao.getDetailProduct(id);
           return View(productModel);
        }
    }
}