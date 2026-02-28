using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AdanaCafe.Models
{
    public class AdanaCafeContext:DbContext
    {
        public AdanaCafeContext() : base("AdanaCafeContext") { } 
        public DbSet<Cafe> Cafes { get; set; }
        public DbSet<Menu> Menus { get; set; }
    }
}