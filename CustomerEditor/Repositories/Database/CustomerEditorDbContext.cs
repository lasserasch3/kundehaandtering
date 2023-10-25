using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Database
{
    public class CustomerEditorDbContext : DbContext
    {

        public DbSet<Models.Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=KundeEditorDb;User Id=ucl;Password=ucl1234;TrustServerCertificate=True");
        }

    }
}
