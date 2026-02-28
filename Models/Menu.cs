using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdanaCafe.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public int CafeId { get; set; }
        public string Category { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public virtual Cafe Cafe { get; set; }
    }
}