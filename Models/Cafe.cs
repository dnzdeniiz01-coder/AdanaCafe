using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdanaCafe.Models
{
    public class Cafe
    {
        public int CafeId { get; set; }
        public string CafeName { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public bool IsStudent { get; set; }
        public bool IsForFamily { get; set; }
        public bool IsForWorking { get; set; }
        public bool IsForFun { get; set; }
        public string PhotoUrl { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }


    }
}