using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DropDownListDemo.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
        public DbSet<Category> Category { get; set; }

        public DbSet<SubCategory> SubCategory { get; set; }

        public DbSet<MainProduct> MainProduct { get; set; }
    }
}
