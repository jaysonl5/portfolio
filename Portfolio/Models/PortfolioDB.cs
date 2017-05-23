using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Portfolio.Models
{
    public class PortfolioDB : DbContext
    {
        public PortfolioDB() : base("name=DefaultConnection")
        {
               
        }
        

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
    }
}