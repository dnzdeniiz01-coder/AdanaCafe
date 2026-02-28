using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdanaCafe.Models;

namespace AdanaCafe.Controllers
{
    public class MenuController : Controller
    {
        
        AdanaCafeContext db = new AdanaCafeContext();
        public ActionResult Index(int id)
        {
            var menus = db.Menus.Where(m => m.CafeId == id).ToList();
            ViewBag.CafeName = db.Cafes.Where(c => c.CafeId == id).Select(c => c.CafeName).FirstOrDefault();
            return View(menus);
        }
       
    }
}