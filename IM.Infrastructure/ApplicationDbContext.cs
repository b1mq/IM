using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IM.Domain;
namespace IM.Infrastructure

{
    public class ApplicationDbContext : DbContext
    {
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<HRDepartment> HRDepartments { get; set; }
        //public DbSet<FinanceDepartment> FinanceDepartments { get; set; }
        //public DbSet<SalaryRecord> SalaryRecords { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<BasketItem> BasketItem{ get; set; }
        public DbSet<PromoCode> Promocode { get; set; }
        public DbSet<User> User {  get; set; }
        public DbSet<Category> Category {  get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}

