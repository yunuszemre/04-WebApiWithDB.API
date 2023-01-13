using _04_WebApiWithDB.Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WebApiWithDB.Repositories.Context
{
    public class ProjeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public ProjeContext(DbContextOptions<ProjeContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DESKTOP-BODOH2U\\SA; Database=EmployeeDB; uid = sa; pwd = 1234");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
