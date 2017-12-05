using AppLogic.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerShop.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            StockPositionManager manager = new StockPositionManager();
            ViewBag.StockManager = manager;
            return View(manager.GetAll());
        }        
    }
}