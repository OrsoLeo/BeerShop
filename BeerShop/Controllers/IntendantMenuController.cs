using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerShop.Controllers
{
    public class IntendantMenuController : Controller
    {
        // GET: IntendantMenu
        public PartialViewResult IntendantMenu()
        {
            return PartialView();
        }
    }
}