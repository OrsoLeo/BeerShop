using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerShop.Controllers
{
    public class HomeMenuController : Controller
    {
        // GET: HomeMenu
        public PartialViewResult HomeMenu()
        {
            return PartialView();
        }
    }
}