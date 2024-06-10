using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LvhLesson08CF.Models
{
    public class LvhBookStore:DbContext
    {
        public LvhBookStore() : base() {
        
        }
        public DbSet<LvhCategory> LvhCategories { get; set; }
        public DbSet<LvhBook> LvhBooks { get; set; }
    }
}