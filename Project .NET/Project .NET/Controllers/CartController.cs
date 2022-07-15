using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.NET.CSDL;
using Project.NET.Models;

namespace Project.NET.Controllers
{
    public class CartController : Controller
    {
        String id_user = "KH01";
        // GET: Cart
        public ActionResult Index()
        {
            List<ProductModel> products = ProductDao.getCartByUser(id_user);
            //Session["products"] = products;
            return View(products);
        }
    }
}