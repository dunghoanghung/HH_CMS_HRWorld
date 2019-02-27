
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using HoangHung_ERP_System.Models;

namespace HoangHung_ERP_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DbContext")
        {

        }

        public DbSet<HRWorld> HRWorlds { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Jobmanager> Jobmanagers { get; set; }
        public DbSet<Company> Companies { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}