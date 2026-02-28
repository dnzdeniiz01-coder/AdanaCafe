using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdanaCafe.Models;

namespace AdanaCafe.Controllers
{
    public class HomeController : Controller
    {
        
        private AdanaCafeContext db = new AdanaCafeContext();

        public ActionResult Index(string search)
        {
            if (!string.IsNullOrWhiteSpace(search))
            {
                string s = search.Trim().ToLower();

                // Veritabanındaki kafeler arasında bu ismi ara
                var hedefKafe = db.Cafes.FirstOrDefault(c => c.CafeName.ToLower().Contains(s));

                // Eğer kafe bulunduysa, direkt Menu Controller'ın Index metoduna ışınla
                if (hedefKafe != null)
                {
                    return RedirectToAction("Index", "Menu", new { id = hedefKafe.CafeId });
                }

                // Eğer kafe bulunamadıysa, Cafe/List sayfasına gönder
                return RedirectToAction("List", "Cafe", new { search = search });
            }

            return View();
        }

    }
}