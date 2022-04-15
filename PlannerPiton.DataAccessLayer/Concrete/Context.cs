using Microsoft.EntityFrameworkCore;
using PlannerPiton.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerPiton.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-6JSJ28T\\SQLEXPRESS;database=DBPlannerPiton; integrated security=true;");

        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Content> Contents { get; set; }
    }
}
