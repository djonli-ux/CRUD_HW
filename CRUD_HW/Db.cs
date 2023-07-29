using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_HW
{
    internal class Db : DbContext
    {
        public DbSet<Product> Products { get; set; } 
        public Db() 
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-TO8EGSF;Database=p01_ef_crud;Trusted_Connection=True;Encrypt=False;");
        }
    }
}
