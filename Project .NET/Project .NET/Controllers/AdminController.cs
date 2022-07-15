using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.NET.CSDL;
using Project.NET.Models;

namespace Project.NET.Controllers
{
    public class AdminController : Controller
    {
        public static List<ProductModel> getProductForPage(int page, int numOfProducts)
        {

            StoreDao storeDao = new StoreDao();
            int[] inventoryAndImport = storeDao.getInventoryAndImport();
            ViewBag.inventory = inventoryAndImport[0];
            ViewBag.import = inventoryAndImport[1];
            List<ItemStore> itemStores = storeDao.getListStore(0, 1);
            ViewBag.store = itemStores;
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
        // GET: Admin
        public ActionResult Index(String param, String page)
        {
            if (page == null)
            {
                page = "1";
            }
            int endPage = getNumOfPage(20);
            ViewBag.currentPage = Int32.Parse(page);
            ViewBag.endPage = endPage;
            List<ProductModel> products = getProductForPage(Int32.Parse(page), 20);
            ViewBag.products = products;

            if (param != null)
            {

                if (param.Equals("thongtinlaptop"))
                {
                    products = getProductForPage(Int32.Parse(page), 20);
                    ViewBag.products = products;
                }
            }
            return View();
        }
    }
}