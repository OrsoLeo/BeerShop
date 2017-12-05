using AppLogic.Dto;
using AppLogic.DtoUpdate;
using AppLogic.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerShop.Controllers
{
    public class IntendantController : Controller
    {
        Manager manager = new Manager();
        public ActionResult Index(int id = 1)
        {
            ViewBag.Stock = manager.Stock.GetAll();

            return View();
        }

        public ActionResult Edit(int id)
        {
            ReadStockPosition rsp = null;
            if (id != 0)
                rsp = manager.Stock.Get(id);

            return View(rsp);
        }

        [HttpPost]
        public ActionResult Edit(UpdateStockPosition update)
        {
            if (ModelState.IsValid)
            {
                manager.Stock.Update(update);
                return RedirectToAction("Index");
            }
            else
                return View(update);
        }

        public PartialViewResult GetTable(string table = "bottle_list")
        {
            switch (table)
            {
                case "stock_list":
                    //ViewBag.Table = manager.Stock.GetAll();
                    return PartialView();
                case "sale_list":
                    //ViewBag.Table = manager.Sales.GetAll();
                    return PartialView();
                case "sale_positon_list":
                    //ViewBag.Table = manager.SalePositions.GetAll();
                    return PartialView();
                case "capacity_list":
                    //ViewBag.Table = manager.Capacities.GetAll();
                    return PartialView();
                case "picture_list":
                    //ViewBag.Table = manager.Pictures.GetAll();
                    return PartialView();
                case "trade_mark_list":
                    //ViewBag.Table = manager.TradeMarks.GetAll();
                    return PartialView();
                case "bottle_list":
                    //ViewBag.Table = (new BeerBottleController()).Get();// manager.BeerBottles.GetAll();
                    return PartialView();
                case "entity_list":
                    //ViewBag.Table = manager.BeerEntities.GetAll();
                    return PartialView();
                case "kind_list":
                    //ViewBag.Table = manager.BeerKinds.GetAll();
                    return PartialView();
                default:
                    return PartialView();

            }       
        }

        public ActionResult Remove(int? id = null)
        {
            //if (id != null)
            //{
            //    Student temp = students.FirstOrDefault(x => x.Id == id);
            //    students.Remove(temp);
            //}
            return RedirectToAction("GetTable");
        }
    }
}