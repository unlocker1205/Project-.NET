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
        // GET: Admin
        public ActionResult Index()
        {

            StoreDao storeDao = new StoreDao();
            int[] inventoryAndImport = storeDao.getInventoryAndImport();
            ViewBag.inventory = inventoryAndImport[0];
            ViewBag.import = inventoryAndImport[1];
            List<ItemStore> itemStores = storeDao.getListStore(0, 1);
            ViewBag.store = itemStores;
            return View();
        }
    }
}