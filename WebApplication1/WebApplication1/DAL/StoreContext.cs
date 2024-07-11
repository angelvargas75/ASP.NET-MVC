using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("conStr")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}