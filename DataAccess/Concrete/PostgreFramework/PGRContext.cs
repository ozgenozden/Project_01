using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.PostgreFramework
{
    public class PGRContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=(localdb)\MSSQLLocalDB;Database=Project01Database;Username=my_user;Password=my_pw;Trusted_Connection=true");
        }

        public DbSet<Log> Logs { get; set; }
    }
}
