using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDbLayer.Models;

namespace WebApiDbLayer
{
    public class ApiDbContext:DbContext
    {
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Students>? Students { get; set; }
        public ApiDbContext() { }
        public ApiDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-AMR2CQS\MSSQLSERVER01;Initial Catalog=WebApiDatabase;Integrated Security=True");
        }

    }
}
