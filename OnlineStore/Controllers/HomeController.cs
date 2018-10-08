using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Controllers
{
    public class HomeController : Controller
    {
        OnlineStoreContext db = new OnlineStoreContext();

        public ActionResult Index()
        {
            return View(db.Categories);
        }
    }
}