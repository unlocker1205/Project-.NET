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
        public ActionResult Index(String page)
        {
            if(page == null)
            {
                page = "1";
            }
            List<ManufacturerModel> manufacturers = ProductDao.getAllProducer();
            List<String> colors = ProductDao.getAllColor();
            List<String> series = ProductDao.getAllSeries();
            List<String> rams = ProductDao.getAllRam();
            List<String> vgas = ProductDao.getAllVGAs();

            ViewBag.manufacturers = manufacturers;
            ViewBag.colors = colors;
            ViewBag.series = series;
            ViewBag.rams = rams;
            ViewBag.vgas = vgas;

            int endPage = ProductServices.getNumOfPage(20);
            List<ProductModel> products = ProductServices.getProductForPage(Int32.Parse(page), 20);
            ViewBag.currentPage = Int32.Parse(page);
            ViewBag.endPage = endPage;
            ViewBag.products = products;

            return View();
        }

    }

    public class ProductServices
    {
        public static List<ProductModel> getProductForPage(int page, int numOfProducts)
        {
            int end = page * numOfProducts;
            int start = end - numOfProducts;
            return ProductDao.getAllProduct(numOfProducts, start);
            
        }

        public static int getNumOfPage(int numOfProduct)
        {
            int totalProducts = ProductDao.getTotalPage();
            int endPage = totalProducts / numOfProduct;
            if (totalProducts % numOfProduct != 0)
            {
                endPage++;
            }
            return endPage;
        }
    }
}