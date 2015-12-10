using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using YouthSportsRegistration.Models;


namespace YouthSportsRegistration.DataContexts
{
    public class ParentDb :  DbContext
    {
        public DbSet< Parent> Parents { get; set; }
    }
}