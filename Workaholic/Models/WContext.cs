using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Workaholic.Models
{
    public class WContext : DbContext
    {
        public WContext() : base("dataConnection")
        {
            Database.SetInitializer(new WInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}