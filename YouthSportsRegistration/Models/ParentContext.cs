using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using YouthSportsRegistration.Models;


namespace YouthSportsRegistration.Models
{
    public class ParentContext : ApplicationDbContext
    {
        public virtual DbSet<Child>  Kids { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
    }
}