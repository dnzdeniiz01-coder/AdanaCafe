using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdanaCafe.Models;

namespace AdanaCafe.Controllers
{
    public class CafeController : Controller
    {
       
        private AdanaCafeContext db = new AdanaCafeContext();

        public ActionResult List(string category, string search)
        {
           
            var cafeQuery = db.Cafes.AsQueryable();

          
            if (!string.IsNullOrWhiteSpace(search))
            {
                string s = search.Trim().ToLower();

                
                var hedefKafe = db.Cafes.ToList().FirstOrDefault(c =>
                    c.CafeName != null && c.CafeName.ToLower().Contains(s));

               
                if (hedefKafe != null)
                {
                    return RedirectToAction("Index", "Menu", new { id = hedefKafe.CafeId });
                }
            }

          
            if (!string.IsNullOrEmpty(category))
            {
                switch (category)
                {
                    case "Student":
                        cafeQuery = cafeQuery.Where(c => c.IsStudent == true);
                        break;
                    case "Family":
                        cafeQuery = cafeQuery.Where(c => c.IsForFamily == true);
                        break;
                    case "Working":
                        cafeQuery = cafeQuery.Where(c => c.IsForWorking == true);
                        break;
                    case "Fun":
                        cafeQuery = cafeQuery.Where(c => c.IsForFun == true);
                        break;
                }
            }

            
            var filteredList = cafeQuery.ToList();
            return View(filteredList);
        }

        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}